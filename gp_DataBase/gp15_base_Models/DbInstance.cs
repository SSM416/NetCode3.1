using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using static gp_DataBase.DbExtend.DbCallContext;

namespace gp_DataBase.gp15_base_Models
{
    public class DbInstance
    {
        public DbContext GetDbInstance()
        {
            gp15_baseContext dbContext = (gp15_baseContext)CallContext.GetData("gp15_baseContext");
            if (dbContext == null)
                return new gp15_baseContext("");
            else
                return dbContext;
        }
    }
}
