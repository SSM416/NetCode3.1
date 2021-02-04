using System;
using System.Collections.Generic;

namespace gp_DataBase.unified_users_Models
{
    public partial class NtPrivateMessage
    {
        public int Id { get; set; }
        public string IsRead { get; set; }
        public string Subject { get; set; }
        public int? FromUsersId { get; set; }
        public string ToUsersId { get; set; }
        public DateTime? SendDate { get; set; }
        public string Content { get; set; }
        public string SendIp { get; set; }
        public string MessageType { get; set; }
        public string Discipline { get; set; }
        public string Districtcounty { get; set; }
        public string Workshop { get; set; }
        public string School { get; set; }
        public string Teachinggroup { get; set; }
        public string Province { get; set; }
        public string FromUsersName { get; set; }
        public string ToUsersName { get; set; }
        public string ToUsersReadId { get; set; }
        public string ToUsersDeleteId { get; set; }
        public int? ProjectId { get; set; }
        public string DomainName { get; set; }
        public int? SchoolId { get; set; }
        public string Science { get; set; }
        public string StudySection { get; set; }
    }
}
