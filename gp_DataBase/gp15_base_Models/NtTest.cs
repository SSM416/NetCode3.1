using System;
using System.Collections.Generic;

namespace gp_DataBase.gp15_base_Models
{
    public partial class NtTest : DbInstance
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string IsApprovaled { get; set; }
        public string IsUsed { get; set; }
        public string IsStudentPermit { get; set; }
        public int? AdminId { get; set; }
        public DateTime? ApprovaleTime { get; set; }
        public int? Answers { get; set; }
        public string Discipline { get; set; }
        public string Province { get; set; }
        public string Districtcounty { get; set; }
        public string Workshop { get; set; }
        public string School { get; set; }
        public string Teachinggroup { get; set; }
    }
}
