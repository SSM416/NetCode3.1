using System;
using System.Collections.Generic;

namespace gp_DataBase.gp15_base_Models
{
    public partial class NtAddArea : DbInstance
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public string Grade { get; set; }
        public string Province { get; set; }
        public int? ProvinceId { get; set; }
        public int? StudentCount { get; set; }
        public int? ProjectId { get; set; }
        public int? Onlinetime { get; set; }
        public int? PgHomeworks { get; set; }
        public int? Answers { get; set; }
        public int? TjHomeworks { get; set; }
        public int? TjTopics { get; set; }
        public int? TjComments { get; set; }
        public int? TjHomeworksId { get; set; }
        public int? TjCommentsId { get; set; }
        public int? Gonggao { get; set; }
        public int? Jianbao { get; set; }
        public string Discipline { get; set; }
        public string Districtcounty { get; set; }
        public string Workshop { get; set; }
        public string School { get; set; }
        public string Teachinggroup { get; set; }
        public string Type { get; set; }
        public string SmallImg { get; set; }
        public string BigImg { get; set; }
        public int? WorkshopCount { get; set; }
        public int? GroupCount { get; set; }
        public int? MembersCount { get; set; }
        public int? ActivitiesCount { get; set; }
        public int? FansCount { get; set; }
        public int? WorkshopLeaderCount { get; set; }
        public string TargetContent { get; set; }
        public string HeadTitle { get; set; }
        public string HeadName { get; set; }
        public string HeadPhone { get; set; }
        public string TrainingTarget { get; set; }
        public string Nickname { get; set; }
        public int? ClickCount { get; set; }
        public int? Browsecount { get; set; }
        public string Xian { get; set; }
        public string WorkShopQq { get; set; }
        public string Science { get; set; }
        public string StudySection { get; set; }
    }
}
