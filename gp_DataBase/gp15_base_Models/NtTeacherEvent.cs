using System;
using System.Collections.Generic;

namespace gp_DataBase.gp15_base_Models
{
    public partial class NtTeacherEvent : DbInstance
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string EventContent { get; set; }
        public string EventLimit { get; set; }
        public string EventType { get; set; }
        public DateTime? EventTime { get; set; }
        public string Location { get; set; }
        public int? NumberOfPeople { get; set; }
        public string HeadImgUrl { get; set; }
        public string IsApprovaled { get; set; }
        public int? EnterAdminId { get; set; }
        public DateTime? EnterTime { get; set; }
        public int? AdminId { get; set; }
        public int? TestId { get; set; }
        public string BookIds { get; set; }
        public string BookNames { get; set; }
        public int? Sort { get; set; }
        public int? ProjectId { get; set; }
        public string Discipline { get; set; }
        public string Districtcounty { get; set; }
        public string Workshop { get; set; }
        public string School { get; set; }
        public string Teachinggroup { get; set; }
        public string Province { get; set; }
        public string Type { get; set; }
        public DateTime? EventTimeEnd { get; set; }
        public string UserType { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public string MainNum { get; set; }
        public string ParticipantCount { get; set; }
        public string EventHarvest { get; set; }
        public string Choice { get; set; }
        public string Promote { get; set; }
        public string ExpertTop { get; set; }
        public string TeacherEventDistinguish { get; set; }
        public string Path { get; set; }
        public string Weikeurl { get; set; }
        public string ResultExcelPath { get; set; }
        public string ResultImagePath { get; set; }
        public string Xian { get; set; }
        public string Science { get; set; }
        public string StudySection { get; set; }
        public double? ClassHour { get; set; }
    }
}
