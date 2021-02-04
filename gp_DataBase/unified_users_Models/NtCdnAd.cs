using System;
using System.Collections.Generic;

namespace gp_DataBase.unified_users_Models
{
    public partial class NtCdnAd : DbInstance
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CourseId { get; set; }
        public int? CoursewareId { get; set; }
        public int? ResourceFileId { get; set; }
        public string ResourceFilePath { get; set; }
        public int? ShowBegin { get; set; }
        public int? ShowTime { get; set; }
        public string LinkUrl { get; set; }
        public string AutoOffFlag { get; set; }
        public int? AutoOffTime { get; set; }
        public string Type { get; set; }
        public string Upbutton { get; set; }
        public string Downbutton { get; set; }
        public string Chk1 { get; set; }
        public string Chk1TxtFlag { get; set; }
        public string Chk2 { get; set; }
        public string Chk2TxtFlag { get; set; }
        public string Chk3 { get; set; }
        public string Chk3TxtFlag { get; set; }
        public string Chk4 { get; set; }
        public string Chk4TxtFlag { get; set; }
        public string Rad1 { get; set; }
        public string Rad1TxtFlag { get; set; }
        public string Rad2 { get; set; }
        public string Rad2TxtFlag { get; set; }
        public string Rad3 { get; set; }
        public string Rad3TxtFlag { get; set; }
        public string Rad4 { get; set; }
        public string Rad4TxtFlag { get; set; }
    }
}
