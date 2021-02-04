using System;
using System.Collections.Generic;

namespace gp_DataBase.unified_users_Models
{
    public partial class NtResourceFile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
        public string Type { get; set; }
        public int? Size { get; set; }
        public DateTime? Createtime { get; set; }
        public int? ResourceId { get; set; }
        public string IsPublished { get; set; }
        public int? PlayRuleId { get; set; }
        public string Labels { get; set; }
        public int? Downloads { get; set; }
        public int? UpTimes { get; set; }
        public int? ProjectId { get; set; }
        public int? PrimalSubjectId { get; set; }
        public string Discipline { get; set; }
        public string Province { get; set; }
        public string Districtcounty { get; set; }
        public string Workshop { get; set; }
        public string School { get; set; }
        public string Teachinggroup { get; set; }
        public string UploadUser { get; set; }
        public string BrowseTime { get; set; }
    }
}
