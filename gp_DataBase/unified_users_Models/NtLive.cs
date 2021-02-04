using System;
using System.Collections.Generic;

namespace gp_DataBase.unified_users_Models
{
    public partial class NtLive
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Guest { get; set; }
        public string Position { get; set; }
        public string Introduces { get; set; }
        public DateTime? LiveTime { get; set; }
        public string ImgPath { get; set; }
        public string SmallImgPath { get; set; }
        public string Content { get; set; }
        public string LiveType { get; set; }
        public int? HuiyiId { get; set; }
        public DateTime? LiveEndTime { get; set; }
        public int? JoinMax { get; set; }
        public string IsApprovaled { get; set; }
        public string Province { get; set; }
        public int? PrimalSubjectId { get; set; }
        public int? SubSubjectId { get; set; }
        public int? ThirdSubjectId { get; set; }
        public string Weburl { get; set; }
        public int? ProjectId { get; set; }
        public int? Userid { get; set; }
        public string UserName { get; set; }
        public string District { get; set; }
        public string IsProvince { get; set; }
        public string IsCounty { get; set; }
        public string ProvinceTop { get; set; }
        public string CountyTop { get; set; }
        public string CountryTop { get; set; }
        public DateTime? ProvinceTopTime { get; set; }
        public DateTime? CountyTopTime { get; set; }
        public DateTime? CountryTopTime { get; set; }
        public string CompereToken { get; set; }
        public string InstructorToken { get; set; }
        public string BackgroundUrl { get; set; }
        public string ReviewUrl { get; set; }
        public string Discipline { get; set; }
        public string Districtcounty { get; set; }
        public string Workshop { get; set; }
        public string School { get; set; }
        public string Teachinggroup { get; set; }
        public string DomainName { get; set; }
        public int? SchoolId { get; set; }
        public int? SurplusJoin { get; set; }
    }
}
