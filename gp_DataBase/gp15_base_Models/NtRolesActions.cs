using System;
using System.Collections.Generic;

namespace gp_DataBase.gp15_base_Models
{
    public partial class NtRolesActions : DbInstance
    {
        public int Id { get; set; }
        public int RolesId { get; set; }
        public int ActionsId { get; set; }
        public DateTime? EnterTime { get; set; }
        public int? EnterAdminId { get; set; }
        public string Listaction { get; set; }
        public string Listshow { get; set; }
    }
}
