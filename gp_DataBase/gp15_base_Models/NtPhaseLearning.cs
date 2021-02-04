using System;
using System.Collections.Generic;

namespace gp_DataBase.gp15_base_Models
{
    public partial class NtPhaseLearning : DbInstance
    {
        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public string School { get; set; }
        public string StudentName { get; set; }
        public int? StudentProjectId { get; set; }
        public int? StudyCount { get; set; }
        public int? QualifiedCount { get; set; }
        public double? QualifiedRate { get; set; }
        public int? Phase { get; set; }
        public int? Type { get; set; }
        public DateTime? InputTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
