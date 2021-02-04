using System;
using System.Collections.Generic;

namespace gp_DataBase.gp15_base_Models
{
    public partial class NtActions : DbInstance
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? FId { get; set; }
        public int? PId { get; set; }
        public string IsMenu { get; set; }
        public string Url { get; set; }
        public int? OrderNumber { get; set; }
        public string RoleType { get; set; }
        public string UserTypes { get; set; }
        public string ActionType { get; set; }
        public string Target { get; set; }
        public string IsToken { get; set; }
        public string IsCommented { get; set; }
        public string Listaction { get; set; }
        public string Listactionname { get; set; }
        public string Listshow { get; set; }
        public string Listshowname { get; set; }
    }
}
