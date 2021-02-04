using System;
using System.Collections.Generic;

namespace gp_DataBase.gp15_base_Models
{
    public partial class NtMainnum : DbInstance
    {
        public int Id { get; set; }
        public string MainName { get; set; }
        public string Discipline { get; set; }
        public int? InputUserId { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? InputTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? Fid { get; set; }
        public string LinkName { get; set; }
        public string JoinEvent { get; set; }
        public DateTime? LinkStartTime { get; set; }
        public DateTime? LinkEndTime { get; set; }
        public string LinkDecription { get; set; }
        public string JoinEventIds { get; set; }
        public string JoinEventTypes { get; set; }
        public string JoinTeacherEvent { get; set; }
        public string JoinTeacherEventIds { get; set; }
        public string JoinTeacherEventTypes { get; set; }
        public int? TopCount { get; set; }
        public int? StepCount { get; set; }
        public string Requirement { get; set; }
        public uint? IsCopy { get; set; }
        public string InputUserName { get; set; }
        public string UpdateUserName { get; set; }
        public string ScienceIds { get; set; }
        public string ScienceNames { get; set; }
    }
}
