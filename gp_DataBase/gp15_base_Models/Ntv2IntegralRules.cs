using System;
using System.Collections.Generic;

namespace gp_DataBase.gp15_base_Models
{
    public partial class Ntv2IntegralRules : DbInstance
    {
        public int Id { get; set; }
        public string VKey { get; set; }
        public double? VValue { get; set; }
        public string PackValues { get; set; }
        public int ValueType { get; set; }
        public int? FId { get; set; }
        public int? ProjectId { get; set; }
        public int? OrderNumber { get; set; }
        public string Description { get; set; }
        public string Remark { get; set; }
        public int? RulesType { get; set; }
        public int? DataId { get; set; }
        public double? ValueLimit { get; set; }
        public string UserType { get; set; }
        public double? ValueQualified { get; set; }
        public int? TotalScoreType { get; set; }
        public int? InputUserId { get; set; }
        public DateTime? InputTime { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
