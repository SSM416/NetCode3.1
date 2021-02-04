using System;
using System.Collections.Generic;

namespace gp_DataBase.unified_users_Models
{
    public partial class NtCourseTeacher
    {
        public int Id { get; set; }
        public int? CourseId { get; set; }
        public int? TeacherId { get; set; }
        public string RelationType { get; set; }
        public string Studying { get; set; }
        public string TeacherName { get; set; }
    }
}
