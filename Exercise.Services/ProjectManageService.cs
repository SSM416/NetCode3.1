using Exercise.Common;
using Exercise.IServices;
using Exercise.IServices.DbContextFactory;
using Exercise.Services.DbFactory;
using gp_DataBase.DbExtend;
using gp_DataBase.gp15_base_Models;
using gp_DataBase.unified_users_Models;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Script.Serialization;

namespace Exercise.Services
{
    public class ProjectManageService : IProjectManageService
    {
        private readonly HttpContext _httpContext;
        private readonly ILogger<ProjectManageService> _logger;
        public readonly IDbContextFactoryService _dbContextFactoryService;
       
        public ProjectManageService(IHttpContextAccessor httpContextAccessor, ILogger<ProjectManageService> logger, IDbContextFactoryService dbContextFactoryService) 
        {
            _httpContext = httpContextAccessor.HttpContext;
            _logger = logger;
            _dbContextFactoryService = dbContextFactoryService;
           
        }
        #region 删除  
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int id)
        {
            int count = -1;
            NtProjectmanage ntProjectmanage = new DBHelper<NtProjectmanage>(_dbContextFactoryService, WriteAndReadEnum.Read).FindByID(id);
            if (ntProjectmanage != null)
            {
                count = new DBHelper<NtProjectmanage>(_dbContextFactoryService, WriteAndReadEnum.Write).Delete(id);
                WebRequest webreq = WebRequest.Create("http:z.chinabett.com/Common/cache_training?chchename=itemList");
                webreq.BeginGetResponse(null, null);
            }
            return count;
        }
        #endregion

        #region 详细
        /// <summary>
        /// 详细
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public NtProjectmanage Details(int id)
        {
            return new DBHelper<NtProjectmanage>(_dbContextFactoryService,WriteAndReadEnum.Read).FindByID(id);
        }
        #endregion

        public T Edit<T>(int id, string isadmin,out string str)
        {
            NtProjectmanage ntProjectmanage = new NtProjectmanage();
            string sb = "";
            if (id > 0)
            {
                ntProjectmanage = new DBHelper<NtProjectmanage>(_dbContextFactoryService, WriteAndReadEnum.Read).FindByID(id);
                ntProjectmanage.isadmin = isadmin;
                if (!string.IsNullOrWhiteSpace(ntProjectmanage.RequiredCourse))
                {
                    string sql = @"select * from nt_course where find_in_set(Id,@required_course)";
                    DbContextSqlQueryCommands dbContextSqlQueryCommands = new DbContextSqlQueryCommands
                    {
                        MySql = new DbContextSqlQueryCommand(sql, new { Id = ntProjectmanage.RequiredCourse })
                    };
                    DbContext dbContext = _dbContextFactoryService.CreateContext(WriteAndReadEnum.Read, ContextNameCommon.unified_users);
                    var ntProjectmanages_list = (List<NtCourse>)DbContextExtensions.Query<NtCourse>(dbContext, dbContextSqlQueryCommands);
                    ntProjectmanage.required_course = ntProjectmanages_list != null ? string.Join(",", ntProjectmanages_list.Select(e => e.Name).ToArray()) : "";
                }
                if (string.IsNullOrWhiteSpace(ntProjectmanage.Image))
                {

                }
                ntProjectmanage.EndTime = ntProjectmanage.EndTime.ToString().Contains("0001-1-1") ? DateTime.Parse("1900/1/1") : ntProjectmanage.EndTime;
                ntProjectmanage.FinishDemand = string.IsNullOrWhiteSpace(ntProjectmanage.FinishDemand) ? "主线活动必须全程参加，且总分不低于60分！" : ntProjectmanage.FinishDemand;
                ntProjectmanage.ProjectType = ntProjectmanage.ProjectType == 0 ? 6 : ntProjectmanage.ProjectType;
                
                string nametype = "";
                foreach (string i in "1,2,3,4,5,6,7,8,9,10".Split(','))
                {
                    switch (i)
                    {
                        case "1": nametype = "16年国培"; break;
                        case "2": nametype = "非国培"; break;
                        case "3": nametype = "河北全员培训"; break;
                        case "4": nametype = "15年国培"; break;
                        case "5": nametype = "17年河北全员"; break;
                        case "6": nametype = "17年国培"; break;
                        case "7": nametype = "18年河北全员"; break;
                        case "8": nametype = "19年江西全员"; break;
                        case "9": nametype = "19年河北全员"; break;
                        case "10": nametype = "能力提升2.0"; break;
                    }
                    if (i == ntProjectmanage.ProjectType.ToString())
                    {
                        sb += "<option value=\"" + i + "\" selected=\"selected\">" + nametype + "</option>";
                    }
                    else
                    {
                        sb += "<option value=\"" + i + "\">" + nametype + "</option>";
                    }
                }
            }
            str = sb;
            return (T)(object)ntProjectmanage;
        }

        public int EditSave(NtProjectmanage ntProjectmanage, string isadmin, string science_ids, string science_names, string mainnum_ids, string mainnum_names, string admin_ids, string admin_names)
        {
            NtUsers user = Common_Helper.GetCookieValue(_httpContext);
            string old_mainids = string.Empty;
            string old_mainnames = string.Empty;
            NtProjectmanage old_promangeModel = new NtProjectmanage();
            DbContext userdbContext = _dbContextFactoryService.GetDb<gp_DataBase.unified_users_Models.NtAddArea>();
            int editstr = -1;
            if (!string.IsNullOrWhiteSpace(isadmin) && isadmin == "1")
            {
                editstr = -2;
            }
            ///
            ////
            ///这块少个验证逻辑需要加上

            try
            {
                ntProjectmanage.ScienceIds = science_ids;
                ntProjectmanage.ScienceNames = science_names;
                if (ntProjectmanage.Id > 0)
                {
                    //DbContext dbContext = _dbContextFactoryService.GetDb<NtProjectmanage>();
                    //dbContext = _dbContextFactoryService.CreateContext(WriteAndReadEnum.Read, ContextNameCommon.unified_users);
                    old_promangeModel = new DBHelper<NtProjectmanage>(_dbContextFactoryService, WriteAndReadEnum.Read).FindByID(ntProjectmanage.Id);

                    if (ntProjectmanage.ProjectType == 0)
                    {
                        ntProjectmanage.ProjectType = old_promangeModel.ProjectType;
                    }
                    if (!string.IsNullOrWhiteSpace(ntProjectmanage.DistrictcountyIds))
                    {
                        string province_name = string.Empty;
                        string districtcounty_name = string.Empty;
                        string districtcounty_ids = string.Empty;
                        int[] int_list = Array.ConvertAll(ntProjectmanage.DistrictcountyIds.Split(','), s => int.Parse(s));
                        userdbContext = _dbContextFactoryService.GetDb<gp_DataBase.unified_users_Models.NtAddArea>(WriteAndReadEnum.Read);
                        List<gp_DataBase.unified_users_Models.NtAddArea> list = userdbContext.Set<gp_DataBase.unified_users_Models.NtAddArea>().Where(e => int_list.Contains(e.Id)).ToList();
                        if (list != null && list.Count > 0)
                        {
                            for (int i = 0; i < list.Count; i++)
                            {
                                province_name += list[i].Province;
                                districtcounty_name += list[i].Districtcounty;
                                districtcounty_ids += list[i].Id;
                                if (i < list.Count - 1)
                                {
                                    province_name += ",";
                                    districtcounty_name += ",";
                                    districtcounty_ids += ",";
                                }
                            }
                        }
                        ntProjectmanage.ProvinceName = province_name;
                        ntProjectmanage.DistrictcountyNames = districtcounty_name;
                        ntProjectmanage.DistrictcountyIds = districtcounty_ids;
                    }
                    if (isadmin == "1" && old_promangeModel.MainnumIds != mainnum_ids)
                    {
                        if (!string.IsNullOrWhiteSpace(old_promangeModel.MainnumIds))
                        {
                            string[] mainids = mainnum_ids.Split(',');
                            string[] mainnames = mainnum_names.Split(',');
                            string copy_str = string.Empty;
                            int index = 0;
                            foreach (string item in mainids)
                            {
                                if (!("," + old_promangeModel.MainnumIds + ",").Contains("," + item + ","))
                                {
                                    copy_str += item;
                                    copy_str += ",";
                                }
                                else
                                {
                                    old_mainids += item;
                                    old_mainids += ",";
                                    old_mainnames += mainnames[index];
                                    old_mainnames += ",";
                                }
                                index++;
                            }
                            if (!string.IsNullOrWhiteSpace(copy_str))
                            {
                                copy_str = copy_str[0..^1];
                                string main_ids = string.Empty;
                                string main_names = string.Empty;
                                Copy_MainNum(mainnum_ids, out main_ids, out main_names, ntProjectmanage.Id, ntProjectmanage.StartTime, ntProjectmanage.EndTime);//复制主线
                                if (!string.IsNullOrWhiteSpace(main_ids))
                                {
                                    ntProjectmanage.MainnumIds = (old_mainids + main_ids);
                                    ntProjectmanage.MainnumNames = (old_mainnames + mainnames);
                                }
                                else
                                {
                                    ntProjectmanage.MainnumIds = !string.IsNullOrEmpty(old_mainids) ? old_mainids[0..^1] : "";
                                    ntProjectmanage.MainnumNames = !string.IsNullOrEmpty(old_mainnames) ? old_mainnames[0..^1] : "";
                                }
                            }
                            else
                            {
                                ntProjectmanage.MainnumIds = mainnum_ids;
                                ntProjectmanage.MainnumNames = mainnum_names;
                            }
                        }
                        else //编辑前主线为空，则全复制主线
                        {
                            string main_ids = string.Empty;
                            string main_names = string.Empty;
                            Copy_MainNum(mainnum_ids, out main_ids, out main_names, ntProjectmanage.Id, ntProjectmanage.StartTime, ntProjectmanage.EndTime);//复制主线
                            ntProjectmanage.MainnumIds = main_ids;
                            ntProjectmanage.MainnumNames = main_names;
                        }
                    }
                    else
                    {
                        ntProjectmanage.MainnumIds = mainnum_ids;
                        ntProjectmanage.MainnumNames = mainnum_names;
                    }
                    //记录修改管理员操作日志
                    if (old_promangeModel != null && old_promangeModel.Id > 0)
                    {
                        List<string> old_admin_ids = new List<string>(old_promangeModel.AdminIds.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries));
                        List<string> new_admin_ids = new List<string>(admin_ids.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries));
                        List<string> ExceptList = old_admin_ids.Except(new_admin_ids).ToList();

                    }
                    //string json_str_ = "{\"id\":\"" + old_promangeModel.name + "\"，\"dnsurl\":\"" + old_promangeModel.dnsurl + "\"}";
                    ntProjectmanage.AdminIds = admin_ids;
                    ntProjectmanage.AdminNames = admin_names;
                    ntProjectmanage.UpdateTime = DateTime.Now;
                    ntProjectmanage.UpdateUserId = user.Id;
                    ntProjectmanage.ProjectType = 4;
                    ntProjectmanage.Image = "http://stugp2014.enetedu.com/uploadFile/edudefaultpublic/images/project_default.jpg";
                    if (!string.IsNullOrEmpty(ntProjectmanage.MainnumIds) && old_promangeModel.StartTime != ntProjectmanage.StartTime)//修改主线时间
                    {
                        string sql = "update nt_mainnum set linkstarttime = @linkstarttime,linkendtime =@linkendtime where find_in_set(Id,@Id)";
                        DbContextSqlQueryCommands dbContextSqlQueryCommands = new DbContextSqlQueryCommands
                        {
                            MySql = new DbContextSqlQueryCommand(sql, new { Id = ntProjectmanage.MainnumIds, linkstarttime = ntProjectmanage.StartTime, linkendtime = ntProjectmanage.EndTime })
                        };
                        DbContext gpdbContext = _dbContextFactoryService.GetDb<NtMainnum>();
                        gpdbContext = _dbContextFactoryService.CreateContext(WriteAndReadEnum.Write, ContextNameCommon.gp15_BaseContext);
                        DbContextExtensions.Exec(gpdbContext, dbContextSqlQueryCommands);
                    }
                    new DBHelper<NtProjectmanage>(_dbContextFactoryService, WriteAndReadEnum.Read).Update(ntProjectmanage);
                    //new Thread(() => new CommonController().LogRecord(user, ntProjectmanage.id, RouteData.Values["Controller"].ToString() + "/EditSave", json_str_, 3, 0)).Start();
                    UpdateProjectInfo(ntProjectmanage, "1,2,3");
                }
                else
                {
                    if (IsExists(ntProjectmanage))
                    {
                        return editstr;
                    }
                    else
                    {
                        if (!string.IsNullOrWhiteSpace(ntProjectmanage.DistrictcountyIds))
                        {
                            string province_name = string.Empty;
                            string districtcounty_name = string.Empty;
                            string districtcounty_ids = string.Empty;
                            int[] int_list = Array.ConvertAll(ntProjectmanage.DistrictcountyIds.Split(','), s => int.Parse(s));
                            List<gp_DataBase.unified_users_Models.NtAddArea> list = userdbContext.Set<gp_DataBase.unified_users_Models.NtAddArea>().Where(e => int_list.Contains(e.Id)).ToList();
                            if (list != null && list.Count > 0)
                            {
                                for (int i = 0; i < list.Count; i++)
                                {
                                    province_name += list[i].Province;
                                    districtcounty_name += list[i].Districtcounty;
                                    districtcounty_ids += list[i].Id;
                                    if (i < list.Count - 1)
                                    {
                                        province_name += ",";
                                        districtcounty_name += ",";
                                        districtcounty_ids += ",";
                                    }
                                }
                            }
                            ntProjectmanage.ProvinceName = province_name;
                            ntProjectmanage.DistrictcountyNames = districtcounty_name;
                            ntProjectmanage.DistrictcountyIds = districtcounty_ids;
                        }
                        ntProjectmanage.MainnumIds = mainnum_ids;
                        ntProjectmanage.MainnumNames = mainnum_names;
                        ntProjectmanage.AdminIds = admin_ids;
                        ntProjectmanage.AdminNames = admin_names;
                        ntProjectmanage.InputTime = DateTime.Now;
                        ntProjectmanage.UpdateTime = DateTime.Now;
                        ntProjectmanage.InputUserId = user.Id;
                        ntProjectmanage.UpdateUserId = user.Id;
                        new DBHelper<NtProjectmanage>(_dbContextFactoryService,WriteAndReadEnum.Write).Add(ntProjectmanage);
                        // new Thread(() => new CommonController().LogRecord(user, proMangeModel.id, RouteData.Values["Controller"].ToString() + "/EditSave", "", 1, 0)).Start();
                        if (isadmin == "1" && !string.IsNullOrEmpty(mainnum_ids))
                        {
                            string main_ids = string.Empty;
                            string main_names = string.Empty;
                            //string json_str = "{\"id\":\"" + proMangeModel.id + "\",\"mainnum_ids\":\"" + proMangeModel.mainnum_ids + "\",\"mainnum_names\":\"" + proMangeModel.mainnum_names + "\"}";
                            Copy_MainNum(mainnum_ids, out main_ids, out main_names, ntProjectmanage.Id, ntProjectmanage.StartTime, ntProjectmanage.EndTime);//复制主线
                            ntProjectmanage.MainnumIds = main_ids;
                            ntProjectmanage.MainnumNames = main_names;
                            new DBHelper<NtProjectmanage>(_dbContextFactoryService,WriteAndReadEnum.Write).Update(ntProjectmanage);
                            //new Thread(() => new CommonController().LogRecord(user, proMangeModel.id, RouteData.Values["Controller"].ToString() + "/EditSave", json_str, 3, 0)).Start();
                        }
                    }
                }
                //更新项目缓存
                //cacheUtils.loadCodeTableMemberCache("gp_projectmanage_list", "", 0);
                //同步项目列表的缓存
                //cacheUtils.syncCodeTable2ListCache("itemList", 0);
                //string url = cacheUtils.getColumnCacheValue("cache_url", "cacheurl");
                WebRequest webreq = WebRequest.Create("http://z.chinabett.com/Common/cache_training?chchename=itemList");
                webreq.BeginGetResponse(null, null);
                return 0;
            }
            catch (Exception ex)
            {
                _logger.LogError("ProjectManage_BLL/EditSave方法出错：" + ex.Message);
                throw ex;
            }
        }

        #region  修改项目名称（修改配置表 ，修改轮播图表，修改学员项目表)

        public void UpdateProjectInfo(NtProjectmanage ntProjectmanage, string index)
        {
            try
            {
                string sql = "";
                DbContext dbContext = null;
                foreach (var item in index.Split(','))
                {
                    switch (item)
                    {
                        case "1":
                            sql = "Update nt_config set Project_name=@project_name where project_id=@project_id";
                            DbContextSqlQueryCommands dbContextSqlQueryCommands = new DbContextSqlQueryCommands
                            {
                                MySql = new DbContextSqlQueryCommand(sql, new { project_id = ntProjectmanage.Id, project_name = ntProjectmanage.Name })
                            };
                            dbContext = _dbContextFactoryService.GetDb<NtConfig>(WriteAndReadEnum.Write);
                            DbContextExtensions.Exec(dbContext, dbContextSqlQueryCommands);
                            break;
                        case "2":
                            sql = "Update nt_cover_picture set Project_name=@project_name where project_id=@project_id";
                            DbContextSqlQueryCommands dbContextSqlQueryCommands_two = new DbContextSqlQueryCommands
                            {
                                MySql = new DbContextSqlQueryCommand(sql, new { project_id = ntProjectmanage.Id, project_name = ntProjectmanage.Name })
                            };
                            dbContext = _dbContextFactoryService.GetDb<NtCoverPicture>(WriteAndReadEnum.Write);
                            DbContextExtensions.Exec(dbContext, dbContextSqlQueryCommands_two);
                            break;
                        case "3":
                            sql = "Update nt_student_project set Project_name=@project_name,Project_image=@project_image where project_id=@project_id";
                            DbContextSqlQueryCommands dbContextSqlQueryCommands_ = new DbContextSqlQueryCommands
                            {
                                MySql = new DbContextSqlQueryCommand(sql, new { project_id = ntProjectmanage.Id, project_name = ntProjectmanage.Name, project_image = ntProjectmanage.Image })
                            };
                            dbContext = _dbContextFactoryService.GetDb<NtStudentProject>(WriteAndReadEnum.Write);
                            DbContextExtensions.Exec(dbContext, dbContextSqlQueryCommands_);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("修改配置项目名称出错：" + ex.Message);
                throw;
            }
        }
        #endregion


        #region 判断项目名称是否占用
        /// <summary>
        /// 判断项目名称是否占用
        /// </summary>
        /// <param name="ntProjectmanage"></param>
        /// <returns></returns>
        public bool IsExists(NtProjectmanage ntProjectmanage)
        {
            try
            {
                DbContext dbContext = _dbContextFactoryService.GetDb<NtProjectmanage>();
                dbContext = _dbContextFactoryService.CreateContext(WriteAndReadEnum.Read, ContextNameCommon.unified_users);
                int count1 = dbContext.Set<NtProjectmanage>().Count(c => EF.Functions.Like(c.Name, ntProjectmanage.Name));
                string sql = "select count(Name) from nt_projectmanage where Name=@name";
                MySqlParameter mySqlParameter = new MySqlParameter("name", "2015“区培”广西信息技术应用能力提升1");
                NtProjectmanage count = dbContext.Set<NtProjectmanage>().FromSqlRaw(sql, mySqlParameter).FirstOrDefault();
                if (count != null)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                _logger.LogError("isExists方法数据库查询错误：" + ex.Message);
                throw ex;
            }
        }
        #endregion


        #region 复制主线
        public void Copy_MainNum(string mainnum_ids, out string new_main_ids, out string new_mainnum_names, int project_id, DateTime? start_time, DateTime? end_time)
        {
            NtUsers user = Common_Helper.GetCookieValue(_httpContext);
            NtMainnum mainmodel = new NtMainnum();
            int[] list = Array.ConvertAll(mainnum_ids.Split(','), s => int.Parse(s));
            DbContext dbContext = _dbContextFactoryService.GetDb<NtMainnum>(WriteAndReadEnum.Read);
            //dbContext = _dbContextFactoryService.CreateContext(WriteAndReadEnum.Read, ContextNameCommon.gp15_BaseContext);
            IList<NtMainnum> mainList = dbContext.Set<NtMainnum>().Where(e => list.Contains(e.Id)).ToList();
            string new_mainids = string.Empty;
            string new_eventids = string.Empty;
            string new_mainnames = string.Empty;
            string new_eventnames = string.Empty;

            //需 out 变量
            new_main_ids = string.Empty;
            new_mainnum_names = string.Empty;

            if (mainList != null && mainList.Count > 0)//项目选择的主线
            {
                int count = 0;
                JavaScriptSerializer jss = new JavaScriptSerializer();
                string itemstr = string.Empty;
                NtMainnum itemmainModel = new NtMainnum();
                NtMainnum itemLinkMainModel = new NtMainnum();
                NtEvent eventmodel = new NtEvent();
                NtEvent ItemEventModel = new NtEvent();
                foreach (NtMainnum item in mainList)//复制新的主线
                {
                    //复制新的主线
                    itemmainModel = new NtMainnum();
                    itemstr = jss.Serialize(item);
                    itemmainModel = jss.Deserialize<NtMainnum>(itemstr);
                    itemmainModel.Id = 0;
                    itemmainModel.InputTime = DateTime.Now;
                    itemmainModel.UpdateTime = DateTime.Now;
                    itemmainModel.InputUserId = user.Id;
                    itemmainModel.InputUserName = user.Name;
                    itemmainModel.UpdateUserId = user.Id;
                    itemmainModel.UpdateUserName = user.Name;
                    itemmainModel.IsCopy = 1;
                    itemmainModel.LinkStartTime = start_time;
                    itemmainModel.LinkEndTime = end_time;
                    itemmainModel.MainName = project_id.ToString() + "_" + item.MainName;//新的名称前边加项目id
                    //dbContext = _dbContextFactoryService.CreateContext(WriteAndReadEnum.Write, ContextNameCommon.gp15_BaseContext);
                    new DBHelper<NtMainnum>(_dbContextFactoryService, WriteAndReadEnum.Write).Add(itemmainModel);
                    new_mainids += itemmainModel.Id;//新的mainnum_id
                    new_mainids += ",";
                    new_mainnames += itemmainModel.MainName;//新的mainnum_names
                    new_mainnames += ",";
                    //复制新的阶段

                    List<NtMainnum> itemmainList = dbContext.Set<NtMainnum>().Where(e => e.Fid == item.Id).ToList();//主线关联的阶段
                    if (itemmainList != null && itemmainList.Count > 0)
                    {
                        foreach (NtMainnum linkitem in itemmainList)
                        {
                            itemstr = string.Empty;
                            itemstr = jss.Serialize(linkitem);
                            itemLinkMainModel = new NtMainnum();
                            itemLinkMainModel = jss.Deserialize<NtMainnum>(itemstr);
                            itemLinkMainModel.Id = 0;
                            itemLinkMainModel.Fid = itemmainModel.Id;
                            itemLinkMainModel.InputTime = DateTime.Now;
                            itemLinkMainModel.UpdateTime = DateTime.Now;
                            itemLinkMainModel.InputUserId = user.Id;
                            itemLinkMainModel.InputUserName = user.Name;
                            itemLinkMainModel.UpdateUserId = user.Id;
                            itemLinkMainModel.UpdateUserName = user.Name;
                            itemLinkMainModel.IsCopy = 1;


                            if (!string.IsNullOrEmpty(linkitem.JoinEventIds))//阶段是否关联活动
                            {
                                int[] ids = Array.ConvertAll(linkitem.JoinEventIds.Split(','), s => int.Parse(s));
                                DbContext dbContext1 = _dbContextFactoryService.GetDb<NtEvent>(WriteAndReadEnum.Read);
                                //dbContext1 = _dbContextFactoryService.CreateContext(WriteAndReadEnum.Read, ContextNameCommon.gp15_BaseContext);
                                IList<NtEvent> itemeventlist = dbContext1.Set<NtEvent>().Where(e => ids.Contains(e.Id)).ToList();
                                if (itemeventlist != null && itemeventlist.Count > 0)
                                {
                                    new_eventids = string.Empty;
                                    new_eventnames = string.Empty;
                                    foreach (NtEvent eventitem in itemeventlist)//复制新的活动
                                    {
                                        itemstr = string.Empty;
                                        itemstr = jss.Serialize(eventitem);
                                        ItemEventModel = jss.Deserialize<NtEvent>(itemstr);
                                        ItemEventModel.Id = 0;
                                        ItemEventModel.IsCopy = 1;
                                        ItemEventModel.AdminId = user.Id;
                                        ItemEventModel.Title = project_id.ToString() + "_" + itemmainModel.Id + "_" + eventitem.Title;
                                        new DBHelper<NtEvent>(_dbContextFactoryService, WriteAndReadEnum.Write).Add(ItemEventModel);
                                        new_eventids += ItemEventModel.Id;
                                        new_eventids += ",";
                                        new_eventnames += ItemEventModel.Title;
                                        new_eventnames += ",";
                                    }
                                    if (!string.IsNullOrEmpty(new_eventids))//新活动复制完成，对应ids更新至 新的阶段，并复制新阶段
                                    {
                                        new_eventids = new_eventids[0..^1];//新的event_ids
                                        itemLinkMainModel.JoinEventIds = new_eventids;
                                        new_eventnames = new_eventnames[0..^1];//新的event_names
                                        itemLinkMainModel.JoinEvent = new_eventnames;
                                    }

                                }//没有阶段关联的活动 则只复制阶段 当前阶段复制结束

                            } //阶段不包含活动 则只复制阶段 当前阶段复制结束
                            if (new DBHelper<NtMainnum>(_dbContextFactoryService, WriteAndReadEnum.Write).Add(itemLinkMainModel) > 0)
                            {
                                count++;
                            }
                        }
                    }//主线不包含阶段 则不复制阶段，当前主线复制结束
                }
                //new Thread(() => new CommonController().LogRecord(users, 0, RouteData.Values["Controller"].ToString() + "/Copy_MainNum", "复制" + count + "条主线", 1, 0)).Start();
                if (!string.IsNullOrEmpty(new_mainids))
                {
                    new_mainids = new_mainids[0..^1];
                    new_mainnames = new_mainnames[0..^1];
                    new_main_ids = new_mainids;
                    new_mainnum_names = new_mainnames;

                }

            }
        }
        #endregion 项目列表

        #region
        /// <summary>
        /// 项目列表
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pagesize"></param>
        /// <returns></returns>
        public IPage<NtProjectmanage> GetList(int page, int pagesize)
        {
            
            var list = new DBHelper<NtProjectmanage>(_dbContextFactoryService, WriteAndReadEnum.Read).PageInfoList(page, pagesize, e => e.Id, null, true);
            string ids = string.Join(",", list.Items.Select(e => e.UpdateUserId.ToString()).ToArray());
            int[] int_list = Array.ConvertAll(ids.Split(','), s => int.Parse(s));
            List<NtUsers> uList = null;
            if (!string.IsNullOrWhiteSpace(ids))
            {
                DbContext dbContext = _dbContextFactoryService.GetDb<NtProjectmanage>();
                dbContext = _dbContextFactoryService.CreateContext(WriteAndReadEnum.Read, ContextNameCommon.unified_users);
                uList = dbContext.Set<NtUsers>().Where(e => int_list.Contains(e.Id)).ToList();
            }
            list.Items.ToList().ForEach(p =>
            {
                p.names = uList.Where(a => a.Id == p.UpdateUserId).Select(a => a.Name).FirstOrDefault();
                if (p.names == null)
                {
                    p.names = "";
                }
            });
            return list;
        }
        #endregion
    }
}
