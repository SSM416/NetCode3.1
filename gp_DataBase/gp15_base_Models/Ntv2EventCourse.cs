using System;
using System.Collections.Generic;

namespace gp_DataBase.gp15_base_Models
{
    public partial class Ntv2EventCourse : DbInstance
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
        public string IsMainnumEvent { get; set; }
        public string StudentName { get; set; }
        public string EventHarvest { get; set; }
        public uint? IsCopy { get; set; }
        public int? StandardChaptersNum { get; set; }
        public double? ClassHour { get; set; }
    }
}
