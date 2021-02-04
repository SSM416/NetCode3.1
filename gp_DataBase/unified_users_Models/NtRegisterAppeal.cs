using System;
using System.Collections.Generic;

namespace gp_DataBase.unified_users_Models
{
    public partial class NtRegisterAppeal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AppealType { get; set; }
        public string Cellphone { get; set; }
        public string Cardnum { get; set; }
        public string Company { get; set; }
        public string CardnumZ { get; set; }
        public string CardnumF { get; set; }
        public string AppealDescribe { get; set; }
        public string AppealState { get; set; }
        public string DisposeRecord { get; set; }
        public int? InputUserId { get; set; }
        public DateTime? InputTime { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
