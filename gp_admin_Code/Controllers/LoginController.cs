using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;
using Exercise.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace gp_admin_Code.Controllers
{
    //[Authorize]
    public class LoginController : Controller
    {
        public readonly ILoginService  _loginServices;
        public LoginController(ILoginService loginService) 
        {
            _loginServices = loginService;
        }
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        ///  登录页面
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        public IActionResult Login() 
        {
            return View();
        }

        /// <summary>
        /// 登录方法
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [AllowAnonymous]
        public async Task<IActionResult> LoginDoAsync(string username, string password)
        {
            int code = await _loginServices.LoginDoAsync(username, password);
            if (code == -1)
            {
                return Json(new { code = -1, msg = "账号或密码错误，请重新输入！" });
            }
            else if (code == 10000)
            {
                return Redirect("/GetView/Index");
            }
            else
            {
                return Redirect("/Roles/Index");
            }
        }

        /// <summary>
        /// 注销
        /// </summary>
        public ActionResult SignOutClain()
        {
            _loginServices.SignOutClain();
            return RedirectToAction("Login", "Login");
        }
    }
}
