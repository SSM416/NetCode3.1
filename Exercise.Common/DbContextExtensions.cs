using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Reflection;
using System.Text;

namespace Exercise.Common
{
    /// <summary>
    /// 数据库查询语句
    /// </summary>
    public class DbContextSqlQueryCommand
    {
        /// <summary>
        /// 使用不含参数的查询语句
        /// </summary>
        /// <param name="query"></param>
        public DbContextSqlQueryCommand(string query)
        {
            Query = query;
        }
        /// <summary>
        /// 使用包含参数的查询语句
        /// </summary>
        /// <param name="query"></param>
        public DbContextSqlQueryCommand(string query, object @params)
        {
            Query = query;
            Parameters = @params;
        }
        /// <summary>
        /// 查询语句
        /// </summary>
        public string Query { get; set; }
        /// <summary>
        /// 参数
        /// </summary>
        public object Parameters { get; set; }
    }

    /// <summary>
    /// 数据库查询语句集合
    /// </summary>
    public class DbContextSqlQueryCommands
    {
        /// <summary>
        /// 数据库为SqlServer时使用的查询语句
        /// </summary>
        public DbContextSqlQueryCommand Sql { get; set; }
        /// <summary>
        /// 数据库为MySql时使用的查询语句
        /// </summary>
        public DbContextSqlQueryCommand MySql { get; set; }
    }

    /// <summary>
    /// 数据库类型
    /// </summary>
    public enum DbContextType
    {
        InMemory = 0,
        SqlServer = 1,
        MySql = 2,
    }

    /// <summary>
    /// EF上下文扩展
    /// </summary>
    public static class DbContextExtensions
    {
        //拼接参数
        private static void combineParams(DbContextType type, ref DbCommand command, object @params = null)
        {
            if (@params != null)
            {
                Type paramType;
                string prefix;
                switch (type)
                {
                    case DbContextType.InMemory:
                        throw new Exception("未实现的数据库类型");
                    case DbContextType.SqlServer:
                        paramType = typeof(MySqlParameter);
                        prefix = "@";
                        break;
                    case DbContextType.MySql:
                        paramType = typeof(MySqlParameter);
                        prefix = "@";
                        break;
                    default:
                        throw new Exception("未实现的数据库类型");
                }
                foreach (var param in @params.GetType().GetProperties())
                {
                    var paramItem = Activator.CreateInstance(paramType, $"{prefix}{param.Name}", param.GetValue(@params));
                    command.Parameters.Add(paramItem);
                }
            }
        }
        //创建命令（同时返回连接符）
        private static DbCommand createCommand(DbContext context, DbContextSqlQueryCommands commands, out DbConnection connection)
        {
            var conn = context.Database.GetDbConnection();
            connection = conn;
            conn.Open();
            var cmd = conn.CreateCommand();

            if (commands.MySql != null && context.Database.IsMySql())
            {
                cmd.CommandText = commands.MySql.Query;
                combineParams(DbContextType.MySql, ref cmd, commands.MySql.Parameters);
            }

            //else if (commands.InMemory != null)
            //{
            //    throw new NotImplementedException();
            //}
            return cmd;
        }

        /// <summary>
        /// 执行sql语句，返回受影响行数
        /// </summary>
        /// <param name="context">EF上下文</param>
        /// <param name="commands">数据库查询语句集合</param>
        /// <returns>受影响行数</returns>
        public static int Exec(this DbContext context, DbContextSqlQueryCommands commands)
        {
            var command = createCommand(context, commands, out var conn);
            var rsl = command.ExecuteNonQuery();
            conn.Close();
            return rsl;
        }
        /// <summary>
        /// 查询数据库
        /// </summary>
        /// <param name="context">EF上下文</param>
        /// <param name="commands">数据库查询语句集合</param>
        /// <returns>数据DataTable</returns>
        public static DataTable Query(this DbContext context, DbContextSqlQueryCommands commands)
        {
            var command = createCommand(context, commands, out var conn);
            var reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            conn.Close();
            return dt;
        }

        /// <summary>
        /// 查询数据库，返回多个查询结果集
        /// </summary>
        /// <param name="context">EF上下文</param>
        /// <param name="commands">数据库查询语句集合</param>
        /// <returns>数据DataSet</returns>
        public static DataSet QuerySet(this DbContext context, DbContextSqlQueryCommands commands)
        {
            var dt = Query(context, commands);
            var ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        /// <summary>
        /// 查询数据库，返回IEnumerable的强类型数据
        /// </summary>
        /// <typeparam name="T">查询结果类型</typeparam>
        /// <param name="context">EF上下文</param>
        /// <param name="commands">数据库查询语句集合</param>
        /// <returns>IEnumerable的强类型数据</returns>
        public static IEnumerable<T> Query<T>(this DbContext context, DbContextSqlQueryCommands commands)
        {
            var dt = Query(context, commands);
            return dt.ToEnumerable<T>();
        }

        /// <summary>
        /// 查询数据库，返回第一条数据
        /// </summary>
        /// <param name="context">EF上下文</param>
        /// <param name="commands">数据库查询语句集合</param>
        /// <returns>查询到的第一条数据或null</returns>
        public static DataRow QueryOne(this DbContext context, DbContextSqlQueryCommands commands)
        {
            var dt = Query(context, commands);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        /// <summary>
        /// 查询数据库，返回第一条强类型数据
        /// </summary>
        /// <typeparam name="T">查询结果类型</typeparam>
        /// <param name="context">EF上下文</param>
        /// <param name="commands">数据库查询语句集合</param>
        /// <returns>查询到的第一条强类型数据</returns>
        public static T QueryOne<T>(this DbContext context, DbContextSqlQueryCommands commands)
        {
            var dr = QueryOne(context, commands);
            return dr.ToObject<T>();
        }

        /// <summary>
        /// 查询数据库，返回唯一数据
        /// </summary>
        /// <param name="context">EF上下文</param>
        /// <param name="commands">数据库查询语句集合</param>
        /// <returns>查询到的唯一数据</returns>
        public static object QueryObject(this DbContext context, DbContextSqlQueryCommands commands)
        {
            var command = createCommand(context, commands, out var conn);
            var rsl = command.ExecuteScalar();
            conn.Close();
            return rsl;
        }

        /// <summary>
        /// 查询数据库，返回唯一强类型数据
        /// </summary>
        /// <typeparam name="T">查询结果类型</typeparam>
        /// <param name="context">EF上下文</param>
        /// <param name="commands">数据库查询语句集合</param>
        /// <returns>查询到的唯一强类型数据</returns>
        public static T QueryObject<T>(this DbContext context, DbContextSqlQueryCommands commands)
        {
            return (T)QueryObject(context, commands);
        }
    }


    /// <summary>
    /// 数据相关扩展
    /// </summary>
    public static class DataExtensions
    {
        //从属性列表为DataTable创建列
        private static void createColumns(DataTable table, PropertyInfo[] piArr)
        {
            table.Columns.Clear();
            foreach (var pi in piArr)
            {
                table.Columns.Add(pi.Name, pi.PropertyType);
            }
        }

        //用obj的属性填充row
        private static void fillDataRow(DataRow row, object obj, PropertyInfo[] piArr)
        {
            foreach (var pi in piArr)
            {
                row[pi.Name] = pi.GetValue(obj);
            }
        }

        //用row的栏填充obj
        public static void fillObject<T>(T obj, DataRow row, PropertyInfo[] piArr)
        {
            foreach (var pi in piArr)
            {
                try
                {
                    pi.SetValue(obj, row[pi.Name]);
                }
                catch
                {
                }
            }
        }

        /// <summary>
        /// 从类型为DataTable创建Columns
        /// </summary>
        /// <param name="table">DataTable对象</param>
        /// <param name="type">作为创建模板的类型</param>
        public static void CreateColumsFromType(this DataTable table, Type type)
        {
            PropertyInfo[] piArr = type.GetProperties();
            createColumns(table, piArr);
        }

        /// <summary>
        /// 从object为DataTable创建Columns
        /// </summary>
        /// <param name="table">DataTable对象</param>
        /// <param name="obj">作为创建模板的object</param>
        public static void CreateColumsFromObject(this DataTable table, object obj)
        {
            CreateColumsFromType(table, obj.GetType());
        }

        /// <summary>
        /// 将DataRow转换为强类型
        /// </summary>
        /// <typeparam name="T">要转换为的强类型</typeparam>
        /// <param name="row">要转换的DataRow对象</param>
        /// <returns>转换后的强类型对象</returns>
        public static T ToObject<T>(this DataRow row)
        {
            if (row == null)
            {
                return default(T);
            }
            var obj = Activator.CreateInstance<T>();
            PropertyInfo[] piArr = typeof(T).GetProperties();
            fillObject(obj, row, piArr);
            return obj;
        }

        /// <summary>
        /// 将对象转换为DataRow对象
        /// </summary>
        /// <param name="obj">要转换的对象</param>
        /// <returns>转换后的DataRow对象</returns>
        public static DataRow ToDataRow(this object obj)
        {
            if (obj == null)
            {
                return null;
            }
            PropertyInfo[] piArr = obj.GetType().GetProperties();
            DataTable dt = new DataTable();
            createColumns(dt, piArr);

            DataRow row = dt.NewRow();
            fillDataRow(row, obj, piArr);

            return row;
        }

        /// <summary>
        /// 将对象转换为属于指定DataTable的DataRow对象
        /// </summary>
        /// <param name="table">属于的table</param>
        /// <param name="obj">要转换的对象</param>
        /// <returns>转换后的属于指定DataTable的DataRow对象</returns>
        public static DataRow ToDataRow(this object obj, DataTable table)
        {
            if (obj == null)
            {
                return null;
            }
            PropertyInfo[] piArr = obj.GetType().GetProperties();
            createColumns(table, piArr);

            DataRow row = table.NewRow();
            fillDataRow(row, obj, piArr);

            return row;
        }


        /// <summary>
        /// 将DataTable转换为IEnumerable的强类型对象
        /// </summary>
        /// <typeparam name="T">要转换为的强类型</typeparam>
        /// <param name="table">要转换的DataTable对象</param>
        /// <returns>转换后的IEnumerable的强类型对象</returns>
        public static List<T> ToEnumerable<T>(this DataTable table)
        {
            List<T> list = new List<T>();
            PropertyInfo[] piArr = typeof(T).GetProperties();
            foreach (DataRow row in table.Rows)
            {
                var obj = Activator.CreateInstance<T>();
                fillObject(obj, row, piArr);
                list.Add(obj);
            }
            return list;
        }

        /// <summary>
        /// 将IEnumerable的强类型对象转换为DataTable
        /// </summary>
        /// <typeparam name="T">要转换的强类型</typeparam>
        /// <param name="objArr">要转换的IEnumerable的强类型对象</param>
        /// <returns>转换后的DataTable对象</returns>
        public static DataTable ToDataTable<T>(this IEnumerable<T> objArr)
        {
            DataTable dt = new DataTable();
            PropertyInfo[] piArr = typeof(T).GetProperties();
            createColumns(dt, piArr);

            foreach (var obj in objArr)
            {
                DataRow row = dt.NewRow();
                fillDataRow(row, obj, piArr);
                dt.Rows.Add(row);
            }
            return dt;
        }
    }
}
