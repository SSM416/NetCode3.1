using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

namespace gp_DataBase.unified_users_Models
{
    public partial class NtProjectmanage: DbInstance
    {
        public int Id { get; set; }
        public int? SubjectId { get; set; }
        public string Name { get; set; }
        public string Dnsurl { get; set; }
        public string Image { get; set; }
        public string IsBlogs { get; set; }
        public string IsNetresource { get; set; }
        public string IsGallery { get; set; }
        public string IsWeike { get; set; }
        public string Description { get; set; }
        public string IsSchoolbased { get; set; }
        public int? CourseCount { get; set; }
        public int? ForumTopics { get; set; }
        public int? Onlinetime { get; set; }
        public string IsDisplaySusubject { get; set; }
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
        public string Usertype1 { get; set; }
        public string Usertype8 { get; set; }
        public string Usertype6 { get; set; }
        public string Usertype7 { get; set; }
        public string Usertype5 { get; set; }
        public uint? ProjectType { get; set; }
        public string IsSelectMainnum { get; set; }
        public string IsLearningTasks { get; set; }
        public string FinishDemand { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? StartYear { get; set; }
        public string IsClose { get; set; }
        public string RequiredCourse { get; set; }
        public string ScienceIds { get; set; }
        public string ScienceNames { get; set; }
        public string ProjectPay { get; set; }

        [NotMapped]
        public string names { get; set; }
        [NotMapped]
        public string required_course { get; set; }
        [NotMapped]
        public string project_type { get; set; }
        [NotMapped]
        public string isadmin { get; set; }
    }
}
