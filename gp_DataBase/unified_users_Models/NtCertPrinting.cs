using System;
using System.Collections.Generic;

namespace gp_DataBase.unified_users_Models
{
    public partial class NtCertPrinting
    {
        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int? Years { get; set; }
        public int? StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentLoginName { get; set; }
        public string UserType { get; set; }
        public string Cardnumber { get; set; }
        public string Province { get; set; }
        public string Discipline { get; set; }
        public string Districtcounty { get; set; }
        public string Workshop { get; set; }
        public string School { get; set; }
        public string Teachinggroup { get; set; }
        public string CompletionCert { get; set; }
        public string ExcellentCert { get; set; }
        public string ExcellentAdminCert { get; set; }
        public string Science { get; set; }
        public string StudySection { get; set; }
    }
}
