using System;
using System.Collections.Generic;

namespace gp_DataBase.gp15_base_Models
{
    public partial class NtAnswer : DbInstance
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int? QuestionId { get; set; }
        public int? OrderNumber { get; set; }
        public string AnswerType { get; set; }
    }
}
