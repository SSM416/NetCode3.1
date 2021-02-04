using System;
using System.Collections.Generic;

namespace gp_DataBase.unified_users_Models
{
    public partial class NtStudentResourceFile
    {
        public int Id { get; set; }
        public int ResourceFileId { get; set; }
        public int StudentId { get; set; }
        public string Comment { get; set; }
        public DateTime? CommentTime { get; set; }
        public string Path { get; set; }
        public string Type { get; set; }
        public int? Size { get; set; }
        public int? Downloads { get; set; }
        public string Title { get; set; }
        public string Discipline { get; set; }
        public string Province { get; set; }
        public string Districtcounty { get; set; }
        public string Workshop { get; set; }
        public string School { get; set; }
        public string Teachinggroup { get; set; }
        public string IsApproved { get; set; }
        public string UserType { get; set; }
        public string TeacherIsapproved { get; set; }
        public string WorkshopIsapproved { get; set; }
        public string UserName { get; set; }
        public string RescorceFileType { get; set; }
        public int? WebResid { get; set; }
        public int? ProjectId { get; set; }
        public string DomainName { get; set; }
        public int? SchoolId { get; set; }
        public int? EventId { get; set; }
        public int? GRecommended { get; set; }
        public int? WRecommended { get; set; }
        public string Xian { get; set; }
        public int? ZjTopUserid { get; set; }
        public int? ZjTop { get; set; }
        public DateTime? ZjTopTime { get; set; }
        public DateTime? GroupTopTime { get; set; }
        public DateTime? WorkshopTopTime { get; set; }
        public int? IsRecommend { get; set; }
        public DateTime? IsRecommendTime { get; set; }
        public int? Pointnumber { get; set; }
        public int? Grade { get; set; }
        public int? DisciplineType { get; set; }
        public string Science { get; set; }
        public string StudySection { get; set; }
        public string SchoolGrade { get; set; }
    }
}
