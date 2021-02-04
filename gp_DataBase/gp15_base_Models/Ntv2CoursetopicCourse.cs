using System;
using System.Collections.Generic;

namespace gp_DataBase.gp15_base_Models
{
    public partial class Ntv2CoursetopicCourse : DbInstance
    {
        public int Id { get; set; }
        public int? ClassTopicId { get; set; }
        public int? DataId { get; set; }
        public int? CourseJoinType { get; set; }
        public double? ClassHour { get; set; }
        public int? OrderNumber { get; set; }
        public int? InputUserId { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? InputTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
