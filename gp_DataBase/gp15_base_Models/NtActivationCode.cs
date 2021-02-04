using System;
using System.Collections.Generic;

namespace gp_DataBase.gp15_base_Models
{
    public partial class NtActivationCode : DbInstance
    {
        public int Id { get; set; }
        public string ActivationCode { get; set; }
        public string UseYear { get; set; }
        public string ProvinceCode { get; set; }
        public int? ProjectId { get; set; }
        public int? IsUse { get; set; }
        public DateTime? UseTime { get; set; }
        public int? StudentId { get; set; }
        public string StudentName { get; set; }
        public string UserType { get; set; }
        public string Province { get; set; }
        public string Discipline { get; set; }
        public string Districtcounty { get; set; }
        public string Workshop { get; set; }
        public string School { get; set; }
        public string Teachinggroup { get; set; }
        public string Xian { get; set; }
        public int? InputUserId { get; set; }
        public string InputUserName { get; set; }
        public DateTime? InputUserTime { get; set; }
        public string Science { get; set; }
        public string StudySection { get; set; }
    }
}
