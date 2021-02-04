using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace gp_DataBase.DbExtend
{
    public class EFCoreAllContext : DbContext
    {
        private readonly string strConn = string.Empty;

        public EFCoreAllContext(string conn)
        {
            strConn = conn;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(strConn);
        }
    }
}
