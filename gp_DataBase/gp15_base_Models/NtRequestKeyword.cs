using System;
using System.Collections.Generic;

namespace gp_DataBase.gp15_base_Models
{
    public partial class NtRequestKeyword : DbInstance
    {
        public int Id { get; set; }
        public string RequestUrl { get; set; }
        public string ReferrerUrl { get; set; }
        public string RequestForm { get; set; }
        public string RequestIp { get; set; }
        public DateTime? RequestDatetime { get; set; }
    }
}
