using System;
using System.Collections.Generic;

namespace gp_DataBase.gp15_base_Models
{
    public partial class NtTeacherCourse : DbInstance
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Style { get; set; }
        public int? PrimalSubjectId { get; set; }
        public int? SubSubjectId { get; set; }
        public int? ThirdSubjectId { get; set; }
        public double? Payment { get; set; }
        public int? Days { get; set; }
        public string Description { get; set; }
        public int? OrderNumber { get; set; }
        public string Host { get; set; }
        public string IsRecommended { get; set; }
        public int? Clicks { get; set; }
        public string IsApprovaled { get; set; }
        public DateTime? ApprovalTime { get; set; }
        public int? AdminId { get; set; }
        public int? PreTestId { get; set; }
        public int? SucTestId { get; set; }
        public int? EnterAdminId { get; set; }
        public DateTime? EnterTime { get; set; }
        public double? EssentialDurationPercent { get; set; }
        public DateTime? EnrollStartTime { get; set; }
        public DateTime? EnrollEndTime { get; set; }
        public int? WorkRequirementId { get; set; }
        public DateTime? LiveBroadcastTime { get; set; }
        public int? TemplateId { get; set; }
        public int? ForumId { get; set; }
        public string HeadImgUrl { get; set; }
        public int? ElectiveCount { get; set; }
        public string StudyRequery { get; set; }
        public string MainRequery { get; set; }
        public string SelectRequery { get; set; }
        public string BookReview { get; set; }
        public string BbsDescription { get; set; }
        public string ActiveDescription { get; set; }
        public string WorkDescription { get; set; }
        public string WorkRequery { get; set; }
        public string CertificateDescription { get; set; }
        public string CertificateRequery { get; set; }
        public string TeamTeacher { get; set; }
        public int? Sort { get; set; }
        public string IsNecessaryVideo { get; set; }
        public string IsNecessaryWork { get; set; }
        public string IsNecessaryEvent { get; set; }
        public string IsDisplayVideo { get; set; }
        public string IsDisplaySource { get; set; }
        public string IsDisplayEvent { get; set; }
        public string IsDisplayWork { get; set; }
        public string IsDisplayDiscuss { get; set; }
        public string Discipline { get; set; }
        public string Province { get; set; }
        public string Districtcounty { get; set; }
        public string Workshop { get; set; }
        public string School { get; set; }
        public string Teachinggroup { get; set; }
        public string UserType { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public int? ProjectId { get; set; }
        public string Science { get; set; }
        public string StudySection { get; set; }
    }
}
