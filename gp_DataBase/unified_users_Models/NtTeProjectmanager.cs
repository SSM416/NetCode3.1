using System;
using System.Collections.Generic;

namespace gp_DataBase.unified_users_Models
{
    public partial class NtTeProjectmanager
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int? CourseCount { get; set; }
        public string CourseIds { get; set; }
        public string CourseNames { get; set; }
        public string AdminIds { get; set; }
        public string AdminNames { get; set; }
        public int? ProjectType { get; set; }
        public string FinishDemand { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? StartYear { get; set; }
        public string IsClose { get; set; }
        public DateTime? KaibanTime { get; set; }
        public string KaibanAddress { get; set; }
        public string TrainDuration { get; set; }
        public double? TrainCost { get; set; }
        public int? TarinNumberOfPeople { get; set; }
        public string TrainFeature { get; set; }
        public string TrainForm { get; set; }
        public string TrainCourseModality { get; set; }
        public double? ClassHour { get; set; }
        public int? InputUserId { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? InputTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
