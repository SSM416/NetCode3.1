using System;
using System.Collections.Generic;

namespace gp_DataBase.gp15_base_Models
{
    public partial class NtRoles : DbInstance
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? EnterTime { get; set; }
        public int? EnterAdminId { get; set; }
    }
}
