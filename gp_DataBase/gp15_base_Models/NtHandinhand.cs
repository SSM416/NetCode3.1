using System;
using System.Collections.Generic;

namespace gp_DataBase.gp15_base_Models
{
    public partial class NtHandinhand : DbInstance
    {
        public int Id { get; set; }
        public string JoinFrom { get; set; }
        public string JoinTo { get; set; }
        public string JoinType { get; set; }
        public string IsApprovaled { get; set; }
        public int? InputUserId { get; set; }
        public DateTime? InputTime { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string ProvinceFrom { get; set; }
        public string DisciplineFrom { get; set; }
        public string DistrictcountyFrom { get; set; }
        public string SchoolFrom { get; set; }
        public string ProvinceTo { get; set; }
        public string DisciplineTo { get; set; }
        public string DistrictcountyTo { get; set; }
        public string SchoolTo { get; set; }
        public string TeachinggroupFrom { get; set; }
        public string TeachinggroupTo { get; set; }
        public string StudentNameFrom { get; set; }
        public int? LaudNumber { get; set; }
        public string ScienceFrom { get; set; }
        public string ScienceTo { get; set; }
        public string StudySectionFrom { get; set; }
        public string StudySectionTo { get; set; }
    }
}
