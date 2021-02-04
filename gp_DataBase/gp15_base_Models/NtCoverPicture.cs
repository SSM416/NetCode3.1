using System;
using System.Collections.Generic;

namespace gp_DataBase.gp15_base_Models
{
    public partial class NtCoverPicture : DbInstance
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Hyperlink { get; set; }
        public string PictureUrl { get; set; }
        public string PictureType { get; set; }
        public int? ProjectId { get; set; }
        public string ProjectName { get; set; }
    }
}
