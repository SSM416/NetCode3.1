using System;
using System.Collections.Generic;

namespace gp_DataBase.unified_users_Models
{
    public partial class NtCollegeApply
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BannerImg { get; set; }
        public string LogImg { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string SchoolAdmin { get; set; }
        public string Studentpost { get; set; }
        public string Cellphone { get; set; }
        public string Email { get; set; }
        public string AuthorizeVoucher { get; set; }
        public DateTime? ApplyTime { get; set; }
        public int? ApplyUserid { get; set; }
        public string ApplyState { get; set; }
        public string DomainName { get; set; }
        public DateTime? OpeningTime { get; set; }
        public string Telephone { get; set; }
        public string IsRecommend { get; set; }
        public string IsFufei { get; set; }
        public DateTime? FufeiStartTime { get; set; }
        public DateTime? FufeiEndTime { get; set; }
        public int? IsCert { get; set; }
    }
}
