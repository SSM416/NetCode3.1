using System;
using System.Collections.Generic;

namespace gp_DataBase.unified_users_Models
{
    public partial class NtCloudCollege
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Depict { get; set; }
        public string Publishing { get; set; }
        public string Editor { get; set; }
        public string Research { get; set; }
        public string Guidance { get; set; }
        public string Preface { get; set; }
        public string Catalog { get; set; }
        public string Postscript { get; set; }
        public string EditPath { get; set; }
        public string AuthorInterview { get; set; }
        public string Keyword { get; set; }
        public DateTime? InputTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? InputUserId { get; set; }
        public int? UpdateUserId { get; set; }
        public string ImgPath { get; set; }
        public int? ResourceFileId { get; set; }
    }
}
