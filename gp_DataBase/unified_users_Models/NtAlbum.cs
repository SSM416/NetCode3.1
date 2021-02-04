using System;
using System.Collections.Generic;

namespace gp_DataBase.unified_users_Models
{
    public partial class NtAlbum : DbInstance
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ModifyTime { get; set; }
        public int? NumberOfPhotos { get; set; }
        public int? UsersId { get; set; }
        public string CoverUrl { get; set; }
        public string AlbumContent { get; set; }
        public string IsApprovaled { get; set; }
        public string IsPublic { get; set; }
        public string Workshop { get; set; }
        public string School { get; set; }
        public string Teachinggroup { get; set; }
        public int? ProjectId { get; set; }
    }
}
