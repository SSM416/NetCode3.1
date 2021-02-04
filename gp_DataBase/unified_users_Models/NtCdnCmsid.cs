using System;
using System.Collections.Generic;

namespace gp_DataBase.unified_users_Models
{
    public partial class NtCdnCmsid
    {
        public int Id { get; set; }
        public int? ResourceFileId { get; set; }
        public int? IsSend { get; set; }
        public DateTime? SendTime { get; set; }
    }
}
