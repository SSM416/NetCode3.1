using System;
using System.Collections.Generic;

namespace gp_DataBase.gp15_base_Models
{
    public partial class NtWindow : DbInstance
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Images { get; set; }
        public string WindowType { get; set; }
        public string Target { get; set; }
        public string ProgSet { get; set; }
        public string Content { get; set; }
        public int? OrderNumber { get; set; }
        public string IsApprovaled { get; set; }
        public int? Clicks { get; set; }
        public DateTime? EnterTime { get; set; }
        public int? EnterAdminId { get; set; }
        public DateTime? ApprovalTime { get; set; }
        public int? AdminId { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string ProvinceTop { get; set; }
        public string CountyTop { get; set; }
        public DateTime? ProvinceTopTime { get; set; }
        public DateTime? CountyTopTime { get; set; }
        public string IsProvince { get; set; }
        public DateTime? IsProvinceTime { get; set; }
        public string IsCounty { get; set; }
        public DateTime? IsCountyTime { get; set; }
        public string CountryTop { get; set; }
        public DateTime? CountryTopTime { get; set; }
        public int? ProjectId { get; set; }
        public int? PrimalSubjectId { get; set; }
        public string Discipline { get; set; }
        public string Teachinggroup { get; set; }
        public string Districtcounty { get; set; }
        public string Workshop { get; set; }
        public string School { get; set; }
        public string UserType { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Istop { get; set; }
        public DateTime? TopTime { get; set; }
    }
}
