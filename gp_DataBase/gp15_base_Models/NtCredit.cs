using System;
using System.Collections.Generic;

namespace gp_DataBase.gp15_base_Models
{
    public partial class NtCredit : DbInstance
    {
        public int Id { get; set; }
        public uint? CommentLimit { get; set; }
        public uint? OnlinetimeLimit { get; set; }
        public uint? EnrollmentLimit { get; set; }
        public uint? HomeworkLimit { get; set; }
        public uint? ResourcesLimit { get; set; }
        public uint? WeikesLimit { get; set; }
        public uint? NoticeLimit { get; set; }
        public uint? HomeworkTopLimit { get; set; }
        public uint? PercentrateLimit { get; set; }
        public uint? HandinhandLimit { get; set; }
        public uint? ResourcesTopLimit { get; set; }
        public string StudentMerge { get; set; }
        public string GroupMerge { get; set; }
        public string WorkshopMerge { get; set; }
        public int? InputUserId { get; set; }
        public DateTime? InputTime { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string IsApprovaled { get; set; }
        public int? ProjectId { get; set; }
        public double? Passes { get; set; }
        public double? FullMarks { get; set; }
        public double? MainnumeventLimt { get; set; }
        public double? EtcaeterasLimt { get; set; }
        public double? MainnumeventLimtWorkshop { get; set; }
        public double? EtcaeterasLimtWorkshop { get; set; }
        public double? MainnumeventLimtTeachinggroup { get; set; }
        public double? EtcaeterasLimtTeachinggroup { get; set; }
        public double? RequiredCourseEvent { get; set; }
        public double? ElectiveCourserEvent { get; set; }
        public double? LiveEvent { get; set; }
        public double? CasestudyEvent { get; set; }
        public double? ReadingEvent { get; set; }
        public double? ResourceEvent { get; set; }
        public double? WeikeEvent { get; set; }
        public double? QuestionEvent { get; set; }
        public double? Live { get; set; }
        public double? LiveLimt { get; set; }
        public string QxandXzMerge { get; set; }
        public double? GiveNotice { get; set; }
        public double? GiveNoticeLimit { get; set; }
        public int? IsSjmark { get; set; }
        public int? SjmarkLimit { get; set; }
    }
}
