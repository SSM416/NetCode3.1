using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using gp_admin_Code.Models;
using Microsoft.EntityFrameworkCore;
using gp_DataBase.unified_users_Models;
using gp_DataBase.DbExtend;
using gp_DataBase.gp15_base_Models;

namespace gp_admin_Code.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            #region
            //DbContext _gp15_BaseContext = _DbContextFactory.GetDb<gp_DataBase.unified_users_Models.NtAddress>();
            //var a = _gp15_BaseContext.Set<gp_DataBase.unified_users_Models.NtAddress>().Where(e => e.Id == 1).FirstOrDefault();
            //if (_gp15_BaseContext != null)
            //{
            //    _gp15_BaseContext = _DbContextFactory.CreateContext(WriteAndReadEnum.Read, ContextNameCommon.unified_users);
            //    gp_DataBase.unified_users_Models.NtAddress ntAddress = new DBHelper<gp_DataBase.unified_users_Models.NtAddress>(_gp15_BaseContext).FindByID(6);
            //    if (ntAddress != null)
            //    {

            //    }
            //    _gp15_BaseContext = (gp15_baseContext)_DbContextFactory.CreateContext(WriteAndReadEnum.Read, ContextNameCommon.gp15_BaseContext);

            //    new DBHelper<NtLabel>(_gp15_BaseContext).Delete(6);
            //}
            #endregion
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
