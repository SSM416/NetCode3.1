using Exercise.IServices.DbContextFactory;
using gp_DataBase.DbExtend;
using gp_DataBase.gp15_base_Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.IServices
{
   public interface ILoginService
    {
        Task<int> LoginDoAsync(string username, string password);
        void SignOutClain();
        List<T> Left<T>();
        IPage<T> GetRolesList<T>(int page, int pagesize);
        NtRoles NtRolesEdit(int id);
    }
}
