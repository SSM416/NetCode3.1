using System;
using System.Collections.Generic;

namespace gp_DataBase.gp15_base_Models
{
    public partial class NtQuestion : DbInstance
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int? TestId { get; set; }
        public string QuestionType { get; set; }
    }
}
