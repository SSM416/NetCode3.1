using System;
using System.Collections.Generic;

namespace gp_DataBase.gp15_base_Models
{
    public partial class NtLabel : DbInstance
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? InputUserId { get; set; }
        public string InputUserName { get; set; }
        public string InputUserType { get; set; }
        public DateTime? InputTime { get; set; }
        public int? ProjectId { get; set; }
    }
}
