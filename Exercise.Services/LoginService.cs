using Exercise.Common;
using Exercise.Common.Util;
using Exercise.IServices;
using Exercise.IServices.Redis;
using Exercise.IServices.DbContextFactory;
using gp_DataBase.DbExtend;
using gp_DataBase.gp15_base_Models;
using gp_DataBase.unified_users_Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication.Cookies;
using Exercise.Services.DbFactory;

namespace Exercise.Services
{
    public class LoginService : ILoginService
    {
        public readonly gp15_baseContext gp15_BaseContext;
        public readonly unified_usersContext _unified_UsersContext;
        public readonly ILogger<LoginService> _logger;
        public readonly HttpContext _httpContext;
        public readonly IHttpContextAccessor _httpContextAccessor;
        public readonly IRedisManagerService redisManager;
        public readonly IDbContextFactoryService _dbContextFactory;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public LoginService(ILogger<LoginService> logger, gp15_baseContext _gp15_BaseContext, unified_usersContext unified_UsersContext, IHttpContextAccessor httpContextAccessor, IRedisManagerService _redisManager, IDbContextFactoryService dbContextFactory) 
        {
            gp15_BaseContext = _gp15_BaseContext;
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
            _httpContext = httpContextAccessor.HttpContext;
            _unified_UsersContext = unified_UsersContext;
            redisManager = _redisManager;
            _dbContextFactory = dbContextFactory;
        }

        #region 管理员权限列表
        public IPage<T> GetRolesList<T>(int page, int pagesize)
        {
            DbContext dbContext = _dbContextFactory.GetDb<NtUsers>(WriteAndReadEnum.Read);
            //dbContext = _dbContextFactory.CreateContext(WriteAndReadEnum.Read, ContextNameCommon.unified_users);
            var list = new DBHelper<NtActions>(_dbContextFactory, WriteAndReadEnum.Read).PageInfoList(page, pagesize, e => e.Id, e => e.Name.Contains("权限"));
            return (IPage<T>)list;
        }
        #endregion

        #region  左边菜单
        public List<T> Left<T>()
        {
            try
            {
                NtUsers user = Common_Helper.GetCookieValue(_httpContext);
                List<NtActions> myList = redisManager.Get<NtActions>("actionsList_" + user.Id);
                List<NtActions> gpadmin_actionsList = redisManager.Get<NtActions>("gpadmin_actionsList");
                List<NtActions> ntActions = null;
                if (gpadmin_actionsList == null)
                {
                    DbContext dbContext = _dbContextFactory.CreateContext(WriteAndReadEnum.Read, ContextNameCommon.gp15_BaseContext);
                    var query = dbContext.Set<NtActions>().Where(e => e.ActionType != "1" || (Convert.ToInt32(e.ActionType) > 1)).OrderBy(e => e.PId).OrderBy(e => e.OrderNumber).OrderBy(e => e.Id).ToList();
                    if (query != null)
                    {
                        redisManager.Set("gpadmin_actionsList", query, 24 * 60 * 60);
                    }
                    ntActions = query;
                }
                else
                {
                    ntActions = gpadmin_actionsList;
                }
                List<NtActions> actionsList = new List<NtActions>();
                if (ntActions != null)
                {
                    foreach (var item in ntActions)
                    {
                        if (!("9".Equals(item.ActionType) || "X".Equals(item.ActionType)))
                        {
                            continue;
                        }
                        if ("1".Equals(item.IsMenu))
                        {
                            bool flag = false;
                            //不需要权限控制
                            if ("9".Equals(item.RoleType))
                            {
                                flag = true;
                            }
                            //按照用户类型控制
                            else if ("2".Equals(item.RoleType))
                            {
                                if (item.UserTypes.IndexOf(user.UserType) > -1)
                                {
                                    flag = true;
                                }
                            }
                            else if ("1".Equals(item.RoleType))
                            {
                                if ((myList != null) && myList.Where(e => e.Id == item.Id).FirstOrDefault() != null)
                                {
                                    flag = true;
                                }
                            }
                            if (flag)
                            {
                                item.Url = !string.IsNullOrWhiteSpace(item.Url) ? item.Url.Trim() : "";
                                if (!string.IsNullOrWhiteSpace(item.IsToken) && item.IsToken.Equals("1"))
                                {
                                    string url = item.Url.IndexOf("?") > -1 ? item.Url + "&" : item.Url + "?";
                                    url += "tokenId=" + user.Token + "&userId=" + user.Id + "&loginName=" + user.LoginName + "&userType=" + user.UserType;
                                    item.Url = url;
                                }
                                if (item.Target != null && item.Target.Length > 0)
                                {
                                    item.Target = item.Target.Trim();
                                }
                                else
                                {
                                    actionsList.Add(item);
                                }
                            }
                        }
                    }
                    actionsList = getActionsTree(actionsList);
                    return (List<T>)(object)actionsList;
                }
                return null;
            }
            catch (Exception ex)
            {
                _logger.LogError("查询过程中出错:" + ex.Message);
                return null;
            }
        }
        #endregion

        #region 菜单递归
        public List<NtActions> getActionsTree(List<NtActions> list)
        {
            //上级节点ID，根节点ID
            int root = 0;
            List<NtActions> retList = new List<NtActions>();
            //查找第一级节点
            for (int i = 0; i < list.Count; i++)
            {
                NtActions model = list[i];
                if (root == model.PId)
                {
                    retList.Add(model);
                    //递归，查找下级节点
                    getSubActionsTree(model, list, retList);
                }
            }
            return retList;
        }
        public void getSubActionsTree(NtActions parentModel, List<NtActions> list, List<NtActions> retList)
        {
            for (int i = 0; i < list.Count; i++)
            {
                NtActions model = list[i];
                if (model.PId == parentModel.Id)
                {
                    // parentModel.haveSubFlag = true;
                    retList.Add(model);
                    getSubActionsTree(model, list, retList);
                }
            }
        }
        #endregion

        #region  登录方法
        public async Task<int> LoginDoAsync(string username, string password)
        {

            try
            {
                //_dbContextFactory.GetDb<NtUsers>(WriteAndReadEnum.Read);
                //var a1232 = new CdeshiHelper<NtUsers>(_dbContextFactory, ContextNameCommon.unified_users, WriteAndReadEnum.Read).FindByID(1);
                int code = -1;
                NtUsers ntUsers1 = null;
                if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password)) 
                {
                    _session.Remove("LOGIN_VALIDATE_CODE");
                    DbContext dbContext = _dbContextFactory.GetDb<NtUsers>(WriteAndReadEnum.Read);
                    // dbContext = _dbContextFactory.CreateContext(WriteAndReadEnum.Read, ContextNameCommon.unified_users);
                    //NtUsers ntUsers1aa = new DBHelper<NtUsers>(_dbContextFactory, WriteAndReadEnum.Read).List(e => e.LoginName == username && e.Password == MD5Utils.Get32MD5(password)).FirstOrDefault();                    
                    ntUsers1 = dbContext.Set<NtUsers>().Where(e => e.LoginName == username && e.Password == MD5Utils.Get32MD5(password)).FirstOrDefault();
                    if (ntUsers1 != null) 
                    {
                        string jsonstr = JsonConvert.SerializeObject(ntUsers1);
                        _session.SetString("LOGIN_VALIDATE_CODE", jsonstr);
                        _session.SetString("USER_INFO_SESSION_FRONT", JsonConvert.SerializeObject(dbContext.Set<NtUsers>().Where(e => e.LoginName == ntUsers1.LoginName && e.Password == ntUsers1.Password && e.UserType == ntUsers1.UserType).FirstOrDefault()));
                        var userClaims = new List<Claim>()
                        {
                        new Claim(ClaimTypes.Name,ntUsers1.LoginName),
                        new Claim(ClaimTypes.Sid,ntUsers1.Id.ToString()),
                        new Claim("password","")
                        };
                        var grandmaIdentity = new ClaimsIdentity(userClaims, "enet_studentname");
                        var userPrincipal = new ClaimsPrincipal(new[] { grandmaIdentity });
                        await _httpContext.SignInAsync(userPrincipal);
                        ntUsers1.LastLoginTime = DateTime.Now;
                        ntUsers1.LoginTimes += 1;
                        ntUsers1.LastLoginIp = WebUtils.GetRealIP(_httpContext);
                        ntUsers1.Token = GuidUtils.GetGuid();
                        if (ntUsers1.Addglorytime <= DateTime.Parse("1900/01/01"))
                        {
                            ntUsers1.Addglorytime = DateTime.Parse("1900/01/01");
                        }
                        int count = new DBHelper<NtUsers>(_dbContextFactory, WriteAndReadEnum.Write).Update(ntUsers1);
                        //dbContext.Set<NtUsers>().Update(ntUsers1);
                        //dbContext.SaveChanges();
                        if (Common_Helper.IsPassword(password))
                        {
                            code = -2;
                        }
                        else
                        {
                            code = 1;
                        }
                        var value = redisManager.Get("actionsList_" + ntUsers1.Id);
                        if (value == null)
                        {
                            var actionsList = (from a in gp15_BaseContext.NtUsersRoles
                                               join b in gp15_BaseContext.NtRoles on a.RolesId equals b.Id
                                               join c in gp15_BaseContext.NtRolesActions on b.Id equals c.RolesId
                                               join d in gp15_BaseContext.NtActions on c.ActionsId equals d.Id
                                               where a.UsersId == ntUsers1.Id
                                               select d).Distinct().ToList();

                            redisManager.Set("actionsList_" + ntUsers1.Id, actionsList, 24 * 60 * 60);
                        }
                        Common_Helper.SetCookieuser(_httpContext, ntUsers1);
                    }
                }
                return code;
            }
            catch (Exception ex) 
            {
                _logger.LogError("登录过程中出错:" + ex.Message);
                return -1;
            }
        }
        #endregion

        #region 管理员权限编辑 
        public NtRoles NtRolesEdit(int id)
        {
            if (id > 0)
            {
                return new DBHelper<NtRoles>(_dbContextFactory, WriteAndReadEnum.Read).FindByID(id);
            }
            return null;
        }
        #endregion

        #region  退出登录
        /// <summary>
        /// 退出登录
        /// </summary>
        public async void SignOutClain()
        {
            this._session.Remove("USER_INFO_SESSION_BACK");
            this._session.Remove("USER_INFO_SESSION_FRONT");
            await _httpContext.SignOutAsync();
        }
        #endregion
    }
}
