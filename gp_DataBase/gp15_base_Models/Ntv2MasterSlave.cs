using System;
using System.Collections.Generic;

namespace gp_DataBase.gp15_base_Models
{
    public partial class Ntv2MasterSlave : DbInstance
    {
        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public int? UserId { get; set; }
        public int? StudentprojectId { get; set; }
        public string UserType { get; set; }
        public string Dataids { get; set; }
        public string Datatype { get; set; }
        public string Province { get; set; }
        public string Districtcounty { get; set; }
        public string Xian { get; set; }
        public string SchoolName { get; set; }
        public int? InputUserId { get; set; }
        public DateTime? InputTime { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
