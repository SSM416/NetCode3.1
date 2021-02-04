using System;
using System.Collections.Generic;

namespace gp_DataBase.unified_users_Models
{
    public partial class NtProjectmanageFocus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dnsurl { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string SubjectIds { get; set; }
        public string SubjectName { get; set; }
        public string ProvinceIds { get; set; }
        public string ProvinceName { get; set; }
        public string DistrictcountyIds { get; set; }
        public string DistrictcountyNames { get; set; }
        public string MainnumIds { get; set; }
        public string MainnumNames { get; set; }
        public string AdminIds { get; set; }
        public string AdminNames { get; set; }
        public int? InputUserId { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? InputTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public uint? ProjectType { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? StartYear { get; set; }
        public string IsClose { get; set; }
        public string RequiredCourse { get; set; }
        public double? PayMoney { get; set; }
        public int? Peoples { get; set; }
    }
}
