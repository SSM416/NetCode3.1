using System;
using System.Collections.Generic;

namespace gp_DataBase.gp15_base_Models
{
    public partial class NtTeacherEventMainnum : DbInstance
    {
        public int Id { get; set; }
        public int? MainNumId { get; set; }
        public string MainName { get; set; }
        public string LinkName { get; set; }
        public string Province { get; set; }
        public string Discipline { get; set; }
        public string Districtcounty { get; set; }
        public string Workshop { get; set; }
        public string School { get; set; }
        public string Teachinggroup { get; set; }
        public int? TeacherEventId { get; set; }
        public string TeacherEventName { get; set; }
        public string TeacherEventType { get; set; }
        public string FromProvince { get; set; }
        public string FromDiscipline { get; set; }
        public string FromDistrictcounty { get; set; }
        public string FromWorkshop { get; set; }
        public string FromTeachinggroup { get; set; }
        public string FromSchool { get; set; }
        public int? FromType { get; set; }
        public string FromScience { get; set; }
        public string FromStudySection { get; set; }
        public string Science { get; set; }
        public string StudySection { get; set; }
    }
}
