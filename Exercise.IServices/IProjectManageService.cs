using Exercise.IServices.DbContextFactory;
using gp_DataBase.DbExtend;
using gp_DataBase.unified_users_Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise.IServices
{
    public interface IProjectManageService
    {
        #region 查询列表
        /// <summary>
        /// 查询列表
        /// </summary>
        /// <param name="page">页码</param>
        /// <param name="pagesize">页数</param>
        /// <returns></returns>
        IPage<NtProjectmanage> GetList(int page, int pagesize);
        #endregion

        #region  编辑页面
        /// <summary>
        /// 编辑页面
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id">id</param>
        /// <param name="isadmin"></param>
        /// <returns></returns>
        T Edit<T>(int id, string isadmin, out string str);
        #endregion

        #region 编辑保存方法
        /// <summary>
        /// 编辑保存方法
        /// </summary>
        /// <param name="users"></param>
        /// <param name="ntProjectmanage"></param>
        /// <param name="isadmin"></param>
        /// <param name="science_ids"></param>
        /// <param name="science_names"></param>
        /// <param name="mainnum_ids"></param>
        /// <param name="mainnum_names"></param>
        /// <param name="admin_ids"></param>
        /// <param name="admin_names"></param>
        /// <returns></returns>
        int EditSave(NtProjectmanage ntProjectmanage, string isadmin, string science_ids, string science_names, string mainnum_ids, string mainnum_names, string admin_ids, string admin_names);
        #endregion

        #region 详细
        /// <summary>
        ///  详细
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        NtProjectmanage Details(int id);
        #endregion

        #region 删除
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        int Delete(int id);
        #endregion
    }
}
