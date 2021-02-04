using Exercise.IServices.DbContextFactory;
using gp_DataBase.DbExtend;
using gp_DataBase.gp15_base_Models;
using gp_DataBase.unified_users_Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;


namespace Exercise.Services.DbFactory
{
    public class DbContextFactoryService : IDbContextFactoryService
    {
        private static IConfiguration _Configuration;
        public DbContextFactoryService(IConfiguration configuration) //构造函数注入配置
        {
            _Configuration = configuration;
        }

        public DbContext CreateContext(WriteAndReadEnum writeAndRead, string dbcomtextname)
        {
            string sqlConn = string.Empty;
            switch (writeAndRead)
            {
                case WriteAndReadEnum.Write:
                    sqlConn = _Configuration.GetConnectionString(dbcomtextname + "WriteDataBase");//读取主库查询
                    break;
                case WriteAndReadEnum.Read:
                    sqlConn = _Configuration.GetConnectionString(dbcomtextname + "ReadDataBase");//从库查询
                    break;
                default:
                    break;
            }
            if (dbcomtextname.Contains(ContextNameCommon.gp15_BaseContext))
            {
                return new gp15_baseContext(sqlConn);
            }
            else
            {
                return new unified_usersContext(sqlConn);
            }
            //else 
            //{
            //    return new gp15_student(sqlConn);
            //}
        }
        public DbContext GetDb<T>(WriteAndReadEnum writeAndRead)
        {
            Type model = typeof(T);
            //Type baseModel = model.UnderlyingSystemType;
            //object dbinstance = Activator.CreateInstance(model);
            //DbContext res = (DbContext)baseModel.GetMethod("GetDbInstance").Invoke(dbinstance, null);
            //res = CreateContext(writeAndRead, model.FullName.Split('.')[1].Substring(0, model.FullName.Split('.')[1].LastIndexOf("_")) + "Context");
            //return res;
            return CreateContext(writeAndRead, model.FullName.Split('.')[1].Substring(0, model.FullName.Split('.')[1].LastIndexOf("_")) + "Context");
        }

        public DbContext GetDb<T>()
        {
            Type model = typeof(T);
            Type baseModel = model.UnderlyingSystemType;
            object dbinstance = Activator.CreateInstance(model);
            DbContext res = (DbContext)baseModel.GetMethod("GetDbInstance").Invoke(dbinstance, null);
            return res;
        }
    }
}
