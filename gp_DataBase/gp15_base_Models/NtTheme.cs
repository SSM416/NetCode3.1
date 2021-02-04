using System;
using System.Collections.Generic;

namespace gp_DataBase.gp15_base_Models
{
    public partial class NtTheme : DbInstance
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImgPath { get; set; }
        public string Label { get; set; }
        public int? Likes { get; set; }
        public int? Comments { get; set; }
        public int? InputUserId { get; set; }
        public string InputUserName { get; set; }
        public string InputUserType { get; set; }
        public string InputUserHeadimg { get; set; }
        public DateTime? InputTime { get; set; }
        public int? ProjectId { get; set; }
        public string Province { get; set; }
        public string Discipline { get; set; }
        public string Districtcounty { get; set; }
        public string Workshop { get; set; }
        public string School { get; set; }
        public string Teachinggroup { get; set; }
        public int? Type { get; set; }
        public string IsApproved { get; set; }
        public string IsDeleted { get; set; }
        public int? AdminTop { get; set; }
    }
}
