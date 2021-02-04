using System;
using System.Collections.Generic;

namespace gp_DataBase.gp15_base_Models
{
    public partial class Ntv2CourseTopic : DbInstance
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Fid { get; set; }
        public string Description { get; set; }
        public double? ClassHour { get; set; }
        public int? ProjectId { get; set; }
        public int? SubordinateId { get; set; }
        public int? InputUserId { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? InputTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
