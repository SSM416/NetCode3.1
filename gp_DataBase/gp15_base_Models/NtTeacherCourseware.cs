using System;
using System.Collections.Generic;

namespace gp_DataBase.gp15_base_Models
{
    public partial class NtTeacherCourseware : DbInstance
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CourseId { get; set; }
        public string SubLecturer { get; set; }
        public string SubCollege { get; set; }
        public int? Duration { get; set; }
        public DateTime? RecordTime { get; set; }
        public string Description { get; set; }
        public DateTime? ImportTime { get; set; }
        public int? OrderNumber { get; set; }
        public string CoursewareType { get; set; }
        public string IsElective { get; set; }
        public string State { get; set; }
        public string IsApproved { get; set; }
        public int? DurationHours { get; set; }
        public int? DurationMinutes { get; set; }
        public int? DurationSeconds { get; set; }
        public string ResourseUrl { get; set; }
        public int? Cmsid { get; set; }
        public int DeliveryStatus { get; set; }
        public DateTime? DeliveryDate { get; set; }
    }
}
