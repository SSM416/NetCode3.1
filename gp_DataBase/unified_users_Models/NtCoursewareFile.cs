using System;
using System.Collections.Generic;

namespace gp_DataBase.unified_users_Models
{
    public partial class NtCoursewareFile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CourseId { get; set; }
        public int? CoursewareId { get; set; }
        public string IsElective { get; set; }
        public int? ResourceFileId { get; set; }
        public string ResourceFilePath { get; set; }
        public int? OrderNumber { get; set; }
        public string State { get; set; }
        public int? ShowType { get; set; }
        public int? UsersId { get; set; }
        public string Description { get; set; }
        public double? Duration { get; set; }
        public int? Cmsid { get; set; }
        public int DeliveryStatus { get; set; }
        public DateTime? DeliveryDate { get; set; }
    }
}
