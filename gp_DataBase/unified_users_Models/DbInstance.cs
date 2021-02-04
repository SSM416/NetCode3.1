using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using static gp_DataBase.DbExtend.DbCallContext;

namespace gp_DataBase.unified_users_Models
{
   public class DbInstance
    {
        public DbContext GetDbInstance()
        {
            unified_usersContext dbContext = (unified_usersContext)CallContext.GetData("unified_usersContext");
            if (dbContext == null)
                return null;
            else
                return dbContext;
        }
    }
}
