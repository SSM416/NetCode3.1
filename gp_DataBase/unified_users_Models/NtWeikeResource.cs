using System;
using System.Collections.Generic;

namespace gp_DataBase.unified_users_Models
{
    public partial class NtWeikeResource
    {
        public int Id { get; set; }
        public int? Cmsid { get; set; }
        public string Vodsize { get; set; }
        public string Delivery { get; set; }
        public string InFilePath { get; set; }
        public string InFileName { get; set; }
        public string InFileImg { get; set; }
        public string InFilePic { get; set; }
        public string InFileType { get; set; }
        public string InFilePatten { get; set; }
        public string InFileNameOld { get; set; }
        public int? InFileSize { get; set; }
        public string OutFilePath { get; set; }
        public string OutFileName { get; set; }
        public DateTime? UploadDate { get; set; }
        public string EncodeState { get; set; }
        public DateTime? EncodeTime { get; set; }
        public int? UsersId { get; set; }
        public string Ifshow { get; set; }
        public string IsApprovaled { get; set; }
        public string UsersSchool { get; set; }
        public string UsersProvince { get; set; }
        public int? ProjectId { get; set; }
        public int? PrimalSubjectId { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public string IsProvince { get; set; }
        public string IsCounty { get; set; }
        public string ProvinceTop { get; set; }
        public string CountyTop { get; set; }
        public string CountryTop { get; set; }
        public DateTime? ProvinceTopTime { get; set; }
        public DateTime? CountyTopTime { get; set; }
        public DateTime? CountryTopTime { get; set; }
        public string Discipline { get; set; }
        public string Districtcounty { get; set; }
        public string Workshop { get; set; }
        public string School { get; set; }
        public string Teachinggroup { get; set; }
        public string Province { get; set; }
        public int? AlbumId { get; set; }
        public string IsPublic { get; set; }
        public string Science { get; set; }
        public string StudySection { get; set; }
    }
}
