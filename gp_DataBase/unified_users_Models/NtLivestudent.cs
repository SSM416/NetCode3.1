using System;
using System.Collections.Generic;

namespace gp_DataBase.unified_users_Models
{
    public partial class NtLivestudent
    {
        public int Id { get; set; }
        public int? LiveId { get; set; }
        public int? StudentId { get; set; }
        public string UserType { get; set; }
        public string StudentName { get; set; }
        public DateTime? JoinTime { get; set; }
        public string JionContent { get; set; }
        public int? JoinFromType { get; set; }
        public string Province { get; set; }
        public string Discipline { get; set; }
        public string Districtcounty { get; set; }
        public string Workshop { get; set; }
        public string School { get; set; }
        public string Teachinggroup { get; set; }
        public int? ProjectId { get; set; }
        public string Xian { get; set; }
        public int? StudentprojectId { get; set; }
        public uint? JoinState { get; set; }
        public string Science { get; set; }
        public string StudySection { get; set; }
    }
}
