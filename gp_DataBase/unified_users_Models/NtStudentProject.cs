using System;
using System.Collections.Generic;

namespace gp_DataBase.unified_users_Models
{
    public partial class NtStudentProject: DbInstance
    {
        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int? StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentLoginName { get; set; }
        public string UserType { get; set; }
        public string UserHeadImg { get; set; }
        public string Discipline { get; set; }
        public string Province { get; set; }
        public string Districtcounty { get; set; }
        public string Workshop { get; set; }
        public string School { get; set; }
        public string Teachinggroup { get; set; }
        public string IsApprovaled { get; set; }
        public DateTime? InputTime { get; set; }
        public int? InputUserId { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? Mainnum { get; set; }
        public int? Isglory { get; set; }
        public DateTime? Addglorytime { get; set; }
        public int? Addgloryid { get; set; }
        public string Addgloryname { get; set; }
        public string ProjectImage { get; set; }
        public int? ResourceCount { get; set; }
        public int? HomeworkCount { get; set; }
        public string CompletionCert { get; set; }
        public string ExcellentCert { get; set; }
        public string ExcellentAdminCert { get; set; }
        public string OtherCert { get; set; }
        public string HnclassGuid { get; set; }
        public int? TeachingGroupId { get; set; }
        public int? WorkShopId { get; set; }
        public string Xian { get; set; }
        public int? XianId { get; set; }
        public int? LoginTimes { get; set; }
        public int? IsRecommend { get; set; }
        public DateTime? IsRecommendTime { get; set; }
        public string Science { get; set; }
        public string StudySection { get; set; }
        public string StudentLoginNameMi { get; set; }
    }
}
