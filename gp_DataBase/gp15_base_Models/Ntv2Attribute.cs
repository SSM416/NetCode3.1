using System;
using System.Collections.Generic;

namespace gp_DataBase.gp15_base_Models
{
    public partial class Ntv2Attribute : DbInstance
    {
        public int Id { get; set; }
        public string VKey { get; set; }
        public string VValue { get; set; }
        public int? FId { get; set; }
        public int? ProjectId { get; set; }
        public int? OrderNumber { get; set; }
        public string Description { get; set; }
        public int? DictionaryType { get; set; }
        public int? InputUserId { get; set; }
        public DateTime? InputTime { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
