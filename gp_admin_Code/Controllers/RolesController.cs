using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Exercise.Common;
using Exercise.IServices;
using gp_DataBase.gp15_base_Models;
using gp_DataBase.unified_users_Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace gp_admin_Code.Controllers
{
    [Authorize]
    public class RolesController : Controller
    {
        public readonly ILoginService _loginServices;
        //private readonly HttpContext _httpContext;
        public RolesController(ILoginService loginService/*, IHttpContextAccessor httpContextAccessor*/)
        {
            _loginServices = loginService;
            //_httpContext = httpContextAccessor.HttpContext;
        }
        public IActionResult Index()
        {
            //NtUsers user = Common_Helper.GetCookieValue(_httpContext);
            //var userName = User.Identity.IsAuthenticated;
            //var temp = User.FindFirst(ClaimTypes.Sid)?.Value;
            //var password = User.FindFirst("password")?.Value;
            //string a = User.Identity.AuthenticationType;
            //var tem = User.Claims.Select(t => t.Value).ToList();
            return View();
        }

        public IActionResult Left()
        {
            List<NtActions> ntActions = _loginServices.Left<NtActions>();
            return View(ntActions);
        }
        public IActionResult Edit(int id)
        {
            ViewBag.model = _loginServices.NtRolesEdit(id);
            return View();
        }

        public IActionResult Main()
        {
            return View();
        }
        public IActionResult Top()
        {
            return View();
        }
    }
}
