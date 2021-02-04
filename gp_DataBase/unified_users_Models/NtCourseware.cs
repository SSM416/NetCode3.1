using System;
using System.Collections.Generic;

namespace gp_DataBase.unified_users_Models
{
    public partial class NtCourseware
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
        public string Keyword { get; set; }
    }
}
