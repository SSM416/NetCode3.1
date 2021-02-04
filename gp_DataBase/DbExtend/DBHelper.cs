using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace gp_DataBase.DbExtend
{
    #region 分页
    /// <summary>
    /// 分页实体
    /// </summary>
    /// <typeparam name="T">实体</typeparam>
    public class Page<T> : IPage<T>
    {
        /// <summary>
        /// 当前页
        /// </summary>
        public int PageIndex { get; set; }
        /// <summary>
        /// 总页数
        /// </summary>
        public int TotalPages { get; set; }
        /// <summary>
        /// 查询集合总个数
        /// </summary>
        public int TotalItems { get; set; }
        /// <summary>
        /// 每页项数
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// 查询集合
        /// </summary>
        public IList<T> Items { get; set; }
    }

    /// <summary>
    /// 分页实体接口
    /// </summary>
    /// <typeparam name="T">实体</typeparam>
    public interface IPage<T>
    {
        /// <summary>
        /// 当前页
        /// </summary>
        int PageIndex { get; set; }
        /// <summary>
        /// 总页数
        /// </summary>
        int TotalPages { get; set; }
        /// <summary>
        /// 查询集合总个数
        /// </summary>
        int TotalItems { get; set; }
        /// <summary>
        /// 每页项数
        /// </summary>
        int PageSize { get; set; }
        /// <summary>
        /// 查询集合
        /// </summary>
        IList<T> Items { get; set; }
    }
    #endregion
    public class DBHelper<T> where T : class, new()
    {
        private readonly DbContext context;
        public DBHelper(DbContext _context)
        {
            context = _context;
            
        }

        /// <summary>
        /// 新增一个实体
        /// </summary>
        /// <param name="context">数据库上下文</param>
        /// <param name="model">要增加的实体</param>
        /// <returns>受影响行数</returns>
        public int Add(T model)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                int count = 0;
                try
                {
                    EntityState state = context.Entry(model).State;
                    if (state == EntityState.Detached)
                    {
                        context.Entry(model).State = EntityState.Added;
                    }
                    count = context.SaveChanges();
                    transaction.Commit();
                    return count;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }
        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="context">数据库上下文</param>
        /// <param name="list">要添加的list</param>
        /// <returns>受影响的行数</returns>
        public int AddList(IEnumerable<T> list)
        {
            int count = 0;
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    context.AddRange(list);
                    count = context.SaveChanges();
                    transaction.Commit();
                    return count;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    return count;
                }
            }
        }

        /// <summary>
        /// 修改一个实体
        /// </summary>
        /// <param name="context">数据库上下文</param>
        /// <param name="model">要修改的实体</param>
        /// <returns>受影响的行数</returns>
        public int Update(T model)
        {
            using var transaction = context.Database.BeginTransaction();
            int count = 0;
            try
            {
                #region 更新系统用户
                //if (typeof(T) == typeof(NtUsers))
                //{
                //    object ntUsers = model;
                //    NtUsers UpMolde = (NtUsers)ntUsers;
                //    if (string.IsNullOrEmpty(UpMolde.LoginName_2))
                //    {
                //        UpMolde.LoginName_2 = UpMolde.LoginName;
                //    }
                //    if (string.IsNullOrEmpty(UpMolde.Email_2))
                //    {
                //        UpMolde.Email_2 = UpMolde.Email;
                //    }
                //    if (string.IsNullOrEmpty(UpMolde.Cellphone_2))
                //    {
                //        UpMolde.Cellphone_2 = UpMolde.Cellphone;
                //    }
                //    if (string.IsNullOrEmpty(UpMolde.Cardnum_2))
                //    {
                //        UpMolde.Cardnum_2 = UpMolde.Cardnum;
                //    }
                //    if (string.IsNullOrEmpty(UpMolde.CellphoneJP_2))
                //    {
                //        UpMolde.CellphoneJP_2 = UpMolde.CellphoneJp;
                //    }
                //    if (string.IsNullOrEmpty(UpMolde.CellphoneSchool_2))
                //    {
                //        UpMolde.CellphoneSchool_2 = UpMolde.CellphoneSchool;
                //    }
                //}
                #endregion
                context.Set<T>().Attach(model);
                context.Entry(model).State = EntityState.Modified;
                context.Update(model);
                count = context.SaveChanges();
                transaction.Commit();
                return count;
            }
            catch (Exception ex)
            {
                string str = ex.Message;
                transaction.Rollback();
                return count;
            }
        }
        /// <summary>
        /// 批量修改
        /// </summary>
        /// <param name="context">数据库上下文</param>
        /// <param name="list">要修改的list集合</param>
        /// <returns>受影响的行数</returns>
        public int UpdateList(IEnumerable<T> list)
        {
            int count = 0;
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    //#region 更新系统用户
                    //if (typeof(IEnumerable<T>) == typeof(IEnumerable<NtUsers>))
                    //{
                    //    if (list != null)
                    //    {
                    //        foreach (var item in list)
                    //        {
                    //            object ntUsers = item;
                    //            NtUsers UpMolde = (NtUsers)ntUsers;
                    //            if (string.IsNullOrEmpty(UpMolde.LoginName_2))
                    //            {
                    //                UpMolde.LoginName_2 = UpMolde.LoginName;
                    //            }
                    //            if (string.IsNullOrEmpty(UpMolde.Email_2))
                    //            {
                    //                UpMolde.Email_2 = UpMolde.Email;
                    //            }
                    //            if (string.IsNullOrEmpty(UpMolde.Cellphone_2))
                    //            {
                    //                UpMolde.Cellphone_2 = UpMolde.Cellphone;
                    //            }
                    //            if (string.IsNullOrEmpty(UpMolde.Cardnum_2))
                    //            {
                    //                UpMolde.Cardnum_2 = UpMolde.Cardnum;
                    //            }
                    //            if (string.IsNullOrEmpty(UpMolde.CellphoneJP_2))
                    //            {
                    //                UpMolde.CellphoneJP_2 = UpMolde.CellphoneJp;
                    //            }
                    //            if (string.IsNullOrEmpty(UpMolde.CellphoneSchool_2))
                    //            {
                    //                UpMolde.CellphoneSchool_2 = UpMolde.CellphoneSchool;
                    //            }
                    //        }
                    //    }
                    //}
                    //#endregion
                    context.UpdateRange(list);
                    count = context.SaveChanges();
                    transaction.Commit();
                    return count;
                }
                catch (Exception ex)
                {
                    string str = ex.Message;
                    transaction.Rollback();
                    return count;
                }
            }
        }

        /// <summary>
        /// 根据ID删除一个实体
        /// </summary>
        /// <param name="context">数据库上下文</param>
        /// <param name="id">要删除的实体ID</param>
        /// <returns>受影响的行数</returns>
        public int Delete(int id)
        {
            int count = 0;
            try
            {
                T model = FindByID(id);
                count = Delete(model);
                return count;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// 删除一个实体
        /// </summary>
        /// <param name="context">数据库上下文</param>
        /// <param name="model">要删除的实体</param>
        /// <returns>受影响的行数</returns>
        public int Delete(T model)
        {
            int count = 0;
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    context.Set<T>().Attach(model);
                    context.Entry<T>(model).State = EntityState.Deleted;
                    count = context.SaveChanges();
                    transaction.Commit();
                    return count;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    return count;
                }
            }
        }
        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="context">数据库上下文</param>
        /// <param name="list">要删除的list集合</param>
        /// <returns>受影响的行数</returns>
        public int DeleteList(IEnumerable<T> list)
        {
            int count = 0;
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    context.RemoveRange(list);
                    count = context.SaveChanges();
                    transaction.Commit();
                    return count;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    return count;
                }
            }
        }

        /// <summary>
        /// 根据条件查找数据
        /// </summary>
        /// <param name="context">数据库上下文</param>
        /// <param name="whereLambda">筛选条件</param>
        /// <returns>符合条件的list</returns>
        public IList<T> List(Expression<Func<T, bool>> whereLambda)
        {
            try
            {
                if (whereLambda != null)
                    return context.Set<T>().Where(whereLambda).AsQueryable().ToList();
                else
                    return context.Set<T>().AsQueryable().ToList();
            }
            catch (Exception)
            {
                return null;
            }

        }
        #region 
        ///// <summary>
        ///// 根据分页条件查询列表
        ///// </summary>
        ///// <param name="context">数据库上下文</param>
        ///// <param name="pageIndex">第几页</param>
        ///// <param name="pageSize">每一页多少条</param>
        ///// <param name="whereLambda">筛选条件</param>
        ///// <returns>符合条件的list</returns>
        //public IPage<T> PageInfoList(DbContext context, bool isAsc, int pageIndex = 1, int pageSize = 30, Expression<Func<T, bool>> whereLambda = null, Expression<Func<T, int>> keySelector = null)
        //{
        //    try
        //    {
        //        IPage<T> page = new Page<T>()
        //        {
        //            PageIndex = pageIndex,
        //            PageSize = pageSize
        //        };
        //        int skinCount = (pageIndex - 1) * pageSize;

        //        if (whereLambda != null)
        //        {
        //            if (keySelector != null)
        //                page.Items = isAsc ? Set(context).Where(whereLambda).OrderBy(keySelector).AsQueryable().ToList() : Set(context).Where(whereLambda).OrderByDescending(keySelector).AsQueryable().ToList();
        //            else
        //                int count = isAsc ? Set(context).Where(whereLambda).Count() : Set(context).Where(whereLambda).Count();
        //            page.TotalItems = page.Items.Count();
        //            page.TotalPages = page.TotalItems / pageSize;
        //            if ((page.TotalItems % pageSize) != 0) page.TotalPages++;
        //            page.Items.Skip(skinCount).Take(pageSize).ToList();
        //            return page;
        //        }
        //        else
        //        {
        //            if (keySelector != null)
        //                page.Items = isAsc ? Set(context).AsQueryable().OrderBy(keySelector).ToList() : Set(context).AsQueryable().OrderByDescending(keySelector).ToList();
        //            else
        //                page.Items = isAsc ? Set(context).AsQueryable().ToList() : Set(context).AsQueryable().ToList();
        //            page.TotalItems = page.Items.Count();
        //            page.TotalPages = page.TotalItems / pageSize;
        //            if ((page.TotalItems % pageSize) != 0) page.TotalPages++;
        //            page.Items = page.Items.Skip(skinCount).Take(pageSize).ToList();
        //            return page;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        #endregion

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="pageIndex">当前页码</param>
        /// <param name="pageSize">每页大小</param>
        /// <param name="rows">总条数</param>
        /// <param name="orderBy">排序条件（一定要有）</param>
        /// <param name="whereLambda">查询添加（可有，可无）</param>
        /// <param name="isOrder">是否是Order排序</param>
        /// <returns></returns>
        public IPage<T> PageInfoList(int pageIndex, int pageSize, Expression<Func<T, object>> orderBy, Expression<Func<T, bool>> whereLambda = null, bool isOrder = true)
        {
            try
            {
                IPage<T> page = new Page<T>()
                {
                    PageIndex = pageIndex,
                    PageSize = pageSize
                };
                IQueryable<T> data = isOrder ?
                    context.Set<T>().OrderBy(orderBy) :
                    context.Set<T>().OrderByDescending(orderBy);
                page.TotalItems = data.Count();
                page.TotalPages = page.TotalItems / pageSize;
                if ((page.TotalItems % pageSize) != 0) page.TotalPages++;
                if (whereLambda != null)
                {
                    data = data.Where(whereLambda);
                }
                page.Items = data.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
                return page;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="pageIndex">当前页码</param>
        /// <param name="pageSize">每页大小</param>
        /// <param name="rows">总条数</param>
        /// <param name="ordering">排序条件（一定要有）</param>
        /// <param name="whereLambda">查询添加（可有，可无）</param>
        /// <returns></returns>
        public IPage<T> PageInfoList(int pageIndex, int pageSize, Expression<Func<T, object>> orderBy, Expression<Func<T, bool>> whereLambda = null)
        {
            try
            {
                IPage<T> page = new Page<T>()
                {
                    PageIndex = pageIndex,
                    PageSize = pageSize
                };
                var data = context.Set<T>().OrderBy(orderBy);
                page.TotalItems = data.Count();
                page.TotalPages = page.TotalItems / pageSize;
                if ((page.TotalItems % pageSize) != 0) page.TotalPages++;
                if (whereLambda != null)
                {
                    data = (IOrderedQueryable<T>)data.Where(whereLambda);
                }
                page.Items = data.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
                return page;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 获得实体列表
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public DbSet<T> Set()
        {
            return context.Set<T>();
        }
        /// <summary>
        /// 根据id查找实体
        /// </summary>
        /// <param name="id"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public T FindByID(int id)
        {
            return Set().Find(id);
        }

        /// <summary>
        /// 根据多个ID查询列表
        /// </summary>
        /// <param name="context">数据库上下文</param>
        /// <param name="dbName">表名</param>
        /// <param name="ids">ids</param>
        /// <returns></returns>
        //public List<T> GetIds(DbContext context,string dbName,string ids)
        //{
        //    string sql = @"select * from " + dbName + " where find_in_set(Id,@Id)";
        //    DbContextSqlQueryCommands dbContextSqlQueryCommands = new DbContextSqlQueryCommands
        //    {
        //        MySql = new DbContextSqlQueryCommand(sql, new { Id = ids })
        //    };
        //    return (List<T>)DbContextExtensions.Query<T>(context, dbContextSqlQueryCommands);
        //}



        //private T Create()
        //{
        //    return Context.Set<T>().Create();
        //}
    }
}
