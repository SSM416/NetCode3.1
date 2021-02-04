using System;
using System.Collections.Generic;

namespace gp_DataBase.gp15_base_Models
{
    public partial class NtLearning : DbInstance
    {
        public int Id { get; set; }
        public int? UsersCount { get; set; }
        public int? LoginsCount { get; set; }
        public double? LoginRate { get; set; }
        public int? StudyCount { get; set; }
        public double? StudyRate { get; set; }
        public long? OnlineTime { get; set; }
        public int? QualifiedCount { get; set; }
        public double? QualifiedRate { get; set; }
        public int? SjzyQualifiedCount { get; set; }
        public double? SjzyQualifiedRate { get; set; }
        public int? InstructorCount { get; set; }
        public int? ResourceTop { get; set; }
        public int? WeikeTop { get; set; }
        public int? ExcellentHomeworks { get; set; }
        public int? NoticeCount { get; set; }
        public int? EventCount { get; set; }
        public int? SjzyCorrect { get; set; }
        public int? SjzyTjcount { get; set; }
        public string Discipline { get; set; }
        public string Province { get; set; }
        public string Districtcounty { get; set; }
        public string Xian { get; set; }
        public string Workshop { get; set; }
        public string School { get; set; }
        public string Teachinggroup { get; set; }
        public int? WorkshopId { get; set; }
        public int? TeachinggtoupId { get; set; }
        public int? Type { get; set; }
        public int? ProjectId { get; set; }
        public string Science { get; set; }
        public string StudySection { get; set; }
    }
}
