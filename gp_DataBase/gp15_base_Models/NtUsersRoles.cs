using System;
using System.Collections.Generic;

namespace gp_DataBase.gp15_base_Models
{
    public partial class NtUsersRoles : DbInstance
    {
        public int Id { get; set; }
        public int UsersId { get; set; }
        public int RolesId { get; set; }
        public DateTime? EnterTime { get; set; }
        public int? EnterAdminId { get; set; }
    }
}
