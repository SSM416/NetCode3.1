using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercise.Common.Util;
using Exercise.IServices;
using gp_DataBase.unified_users_Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace gp_admin_Code.Controllers
{
    [Authorize]
    public class ProjectManageController : BaseController
    {
        private readonly IProjectManageService _projectService;
        public ProjectManageController(IProjectManageService projectService) : base(new HttpContextAccessor())
        {
            _projectService = projectService;
        }
        public IActionResult Index()
        {
            var list = _projectService.GetList(1, 30);
            return View(list.Items);
            //return Json(new { code = 0, data = _projectService.GetList(1, 30) });
        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <returns></returns>
        public IActionResult Edit()
        {
            saveToken();
            int id = readInt("id");
            string isadmin = read("isadmin");
            
            ViewBag.isadmin = isadmin;
            NtProjectmanage ntProjectmanage = _projectService.Edit<NtProjectmanage>(id, isadmin,out string str);
            ntProjectmanage.project_type = str;
            ViewBag.project_type = new HtmlString(str);
            return View(ntProjectmanage);
        }

        /// <summary>
        /// 编辑保存方法
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public IActionResult EditSave()
        {
            if (isValidateToken())
            {
                NtProjectmanage proMangeModel = new NtProjectmanage();
                read(proMangeModel);
                string isadmin = read("isadmin");
                string science_ids = read("science_ids");
                string science_names = read("science_names");
                string mainnum_ids = read("mainnum_ids");
                string mainnum_names = read("mainnum_names");
                string admin_ids = read("admin_ids");
                string admin_names = read("admin_names");
                int code = _projectService.EditSave(proMangeModel, isadmin, science_ids, science_names, mainnum_ids, mainnum_names, admin_ids, admin_names);
                if (code == 0)
                {
                    if (!string.IsNullOrEmpty(isadmin) && isadmin == "1")
                        return RedirectToAction("Index_Admin", "ProjectManage");
                    else
                        return RedirectToAction("Edit?id="+ proMangeModel.Id, "ProjectManage");
                }
                if (code == -1)
                {
                    return Json(new { code, msg = "项目名称：" + proMangeModel.Name + "已经被使用！" });
                }
                if (code == -2)
                {
                    return RedirectToAction("Edit?isadmin=" + isadmin, "ProjectManage");
                }
            }
            return View();
        }

        /// <summary>
        /// 详细
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public JsonResult Details(int id)
        {
            return Json(new { code = 0, dada = _projectService.Details(id) });
        }

        /// <summary>
        ///  删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [AllowAnonymous]
        public JsonResult Delete(int id)
        {
            if (User.Identity.IsAuthenticated)
            {
                int code = _projectService.Delete(id);
                if (code > 0)
                    return Json(new { code, msg = "删除成功！" });
                else
                    return Json(new { code = -1, msg = "删除失败！" });
            }
            else
            {
                return Json(new { code = 403, msg = "操作失败，请重新登录！" });
            }
        }
    }
}
