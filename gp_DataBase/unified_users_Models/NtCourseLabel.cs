using System;
using System.Collections.Generic;

namespace gp_DataBase.unified_users_Models
{
    public partial class NtCourseLabel
    {
        public int Id { get; set; }
        public int? CourseId { get; set; }
        public string Label { get; set; }
        public int? Clicks { get; set; }
        public int? InputUserId { get; set; }
        public string InputUserName { get; set; }
        public DateTime? InputTime { get; set; }
        public int? UpdateUserId { get; set; }
        public string UpdateUserName { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string IsApprovaled { get; set; }
        public string IsCopy { get; set; }
    }
}
