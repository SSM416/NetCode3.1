using System;
using System.Collections.Generic;

namespace gp_DataBase.unified_users_Models
{
    public partial class NtInvoiceRecords
    {
        public int Id { get; set; }
        public int? StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }
        public string StudentMob { get; set; }
        public string Orderid { get; set; }
        public int Ordertype { get; set; }
        public int? Dataid { get; set; }
        public int Datatype { get; set; }
        public double? Amout { get; set; }
        public string BillCompanyname { get; set; }
        public string BillTtaxpayernumber { get; set; }
        public string BillAddressphone { get; set; }
        public string BillBanknumber { get; set; }
        public string BillRemerk { get; set; }
        public string Description { get; set; }
        public int? IsInvoce { get; set; }
        public string Invocenumber { get; set; }
        public string Invocepath { get; set; }
        public int? OrderNumber { get; set; }
        public string IsApprovaled { get; set; }
        public int? InputUserId { get; set; }
        public DateTime? InputTime { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string InvoiceRemerk { get; set; }
        public string InvoiceRednumber { get; set; }
        public string InvoiceUrl { get; set; }
        public string InvoiceYuannumberDm { get; set; }
        public string InvoiceYuannumberHm { get; set; }
        public string InvoiceRedYy { get; set; }
    }
}
