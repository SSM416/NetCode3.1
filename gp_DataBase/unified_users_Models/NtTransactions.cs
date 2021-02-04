using System;
using System.Collections.Generic;

namespace gp_DataBase.unified_users_Models
{
    public partial class NtTransactions
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ProjectId { get; set; }
        public string OrderNumber { get; set; }
        public string Company { get; set; }
        public string ContactName { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string PostCode { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string TaxpayerNumber { get; set; }
        public string InvoiceTitle { get; set; }
        public int? PaymentMethod { get; set; }
        public int? BankcardType { get; set; }
        public string BankcardNumber { get; set; }
        public string CardholderName { get; set; }
        public string CardholderMobilePhone { get; set; }
        public string CardholderCardNumber { get; set; }
        public string Cvv2 { get; set; }
        public int? TermOfValidity { get; set; }
        public double? PayMoney { get; set; }
        public string PaymentState { get; set; }
        public int? IsDelete { get; set; }
        public int? InputUserId { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? InputTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
