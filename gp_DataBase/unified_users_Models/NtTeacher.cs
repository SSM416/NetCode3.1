using System;
using System.Collections.Generic;

namespace gp_DataBase.unified_users_Models
{
    public partial class NtTeacher
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string Gender { get; set; }
        public string Major { get; set; }
        public string Telephone { get; set; }
        public string Cellphone { get; set; }
        public string College { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string IsLiveHost { get; set; }
        public string AssistantOne { get; set; }
        public string AssistantTwo { get; set; }
        public string AssistantThree { get; set; }
        public string AssistantFour { get; set; }
        public string AssistantFive { get; set; }
        public string AssistantPassword { get; set; }
        public string IsApprovaled { get; set; }
        public DateTime? ApprovalTime { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Nationality { get; set; }
        public string IsInvited { get; set; }
        public string BlogFlag { get; set; }
        public string Name { get; set; }
        public string HeadImgUrl { get; set; }
        public string Districtcounty { get; set; }
        public string Workshop { get; set; }
        public string School { get; set; }
        public string Teachinggroup { get; set; }
        public string Discipline { get; set; }
        public string District { get; set; }
        public int? Age { get; set; }
        public int? Seniority { get; set; }
        public string StudySection { get; set; }
        public string TeacherTitle { get; set; }
        public int? Praise { get; set; }
        public string DomainName { get; set; }
        public string Type { get; set; }
        public string Science { get; set; }
    }
}
