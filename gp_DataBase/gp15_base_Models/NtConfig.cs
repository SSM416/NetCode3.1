using System;
using System.Collections.Generic;

namespace gp_DataBase.gp15_base_Models
{
    public partial class NtConfig : DbInstance
    {
        public int Id { get; set; }
        public string Fieldtitle { get; set; }
        public string Fieldtype { get; set; }
        public string Fieldvalue { get; set; }
        public string Fieldnotes { get; set; }
        public int? ProjectId { get; set; }
        public string ProjectName { get; set; }
    }
}
