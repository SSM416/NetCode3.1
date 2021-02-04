using System;
using System.Collections.Generic;

namespace gp_DataBase.gp15_base_Models
{
    public partial class NtInfor : DbInstance
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Type { get; set; }
        public int? Clicks { get; set; }
        public int? Comment { get; set; }
        public int? InputUserid { get; set; }
        public string InputUsername { get; set; }
        public DateTime? InputTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? AuditTime { get; set; }
        public int? IsTop { get; set; }
        public int? IsApprovaled { get; set; }
    }
}
