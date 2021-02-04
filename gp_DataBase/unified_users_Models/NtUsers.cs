using System;
using System.Collections.Generic;

namespace gp_DataBase.unified_users_Models
{
    public partial class NtUsers:DbInstance
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
        public string TypeFlag { get; set; }
        public string LastLoginIp { get; set; }
        public DateTime? LastLoginTime { get; set; }
        public int? LoginTimes { get; set; }
        public string Token { get; set; }
        public DateTime? InputTime { get; set; }
        public int? InputUserId { get; set; }
        public string Signature { get; set; }
        public string HeadImgUrl { get; set; }
        public int? NumberOfPosts { get; set; }
        public string NickName { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public int? ProjectId { get; set; }
        public string Discipline { get; set; }
        public string Districtcounty { get; set; }
        public string Workshop { get; set; }
        public string School { get; set; }
        public string Teachinggroup { get; set; }
        public int? Isglory { get; set; }
        public DateTime? Addglorytime { get; set; }
        public string Addgloryname { get; set; }
        public int? Addgloryid { get; set; }
        public int? Resourcecount { get; set; }
        public int? Homeworkcount { get; set; }
        public int? Mainnum { get; set; }
        public string CompletionCert { get; set; }
        public string ExcellentCert { get; set; }
        public string ExcellentAdminCert { get; set; }
        public double? Score { get; set; }
        public int? IsGpjh { get; set; }
        public int? IsZgks { get; set; }
        public int? SchoolId { get; set; }
        public string IsSchoolAdmin { get; set; }
        public string Email { get; set; }
        public string Sex { get; set; }
        public string Nationality { get; set; }
        public string Telephone { get; set; }
        public string Cellphone { get; set; }
        public string Qq { get; set; }
        public string Cardnum { get; set; }
        public string PostCode { get; set; }
        public string Beizhuone { get; set; }
        public string Beizhutwo { get; set; }
        public string Beizhuthree { get; set; }
        public string Business { get; set; }
        public string Studentpost { get; set; }
        public string Company { get; set; }
        public string Academy { get; set; }
        public string Subject { get; set; }
        public int IsCellphoneVerified { get; set; }
        public string CellphoneJp { get; set; }
        public int IsCellphoneJpVerified { get; set; }
        public string CellphoneSchool { get; set; }
        public int IsCellphoneSchoolVerified { get; set; }
        public string Projects { get; set; }
        public string TopicType { get; set; }
        public int? TopicCount { get; set; }
        public int? IsApprovaled { get; set; }
        public int? RolesId { get; set; }
        public string PaymentPassword { get; set; }
        public string ZgksCellphone { get; set; }
        public string HighestEducation { get; set; }
        public string University { get; set; }
        public string MajorStudied { get; set; }
        public DateTime? EntryDate { get; set; }
        public string Township { get; set; }
        public string Village { get; set; }
        public int? IsFufei { get; set; }
        public string LoginNameMi { get; set; }
        public string CellphoneMi { get; set; }
        public string CardnumMi { get; set; }
        public string EmailMi { get; set; }
        public string CellphoneJpMi { get; set; }
        public string CellphoneSchoolMi { get; set; }
    }
}
