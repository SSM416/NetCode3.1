using gp_DataBase.DbExtend;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise.IServices.DbContextFactory
{
    public interface IDbContextFactoryService
    {
        DbContext CreateContext(WriteAndReadEnum writeAndRead, string dbcomtextname);
        DbContext GetDb<T>(WriteAndReadEnum writeAndRead);
        DbContext GetDb<T>();
    }
}
