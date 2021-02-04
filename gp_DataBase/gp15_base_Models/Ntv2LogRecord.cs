using System;
using System.Collections.Generic;

namespace gp_DataBase.gp15_base_Models
{
    public partial class Ntv2LogRecord : DbInstance
    {
        public int Id { get; set; }
        public int OperationUserid { get; set; }
        public string OperdtionUsername { get; set; }
        public int? OperationDataid { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? InputTime { get; set; }
        public string OperationFunction { get; set; }
        public int? OperationType { get; set; }
        public string Remarks { get; set; }
    }
}
