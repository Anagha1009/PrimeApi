using System;

namespace PrimeMaritime_API.Models
{
    public class RECEIPT
    {
        public int ID { get; set; }
        public string RECEIPT_NO { get; set; }
        public string INVOICE_NO { get; set; }
        public decimal INVOICE_AMOUNT { get; set; }
        public decimal OUTSTANDING_AMOUNT { get; set; }
        public decimal RECEIVED_AMOUNT { get; set; }
        public string DEPOSIT_CASH_BANK { get; set; }
        public string RECEIPT_REMARKS { get; set; }
    }

    public class RECEIPT_BANK
    {
        public string RECEIPT_NO { get; set; }
        public string BANK_NAME { get; set; }
        public string INS_TYPE { get; set; }
        public string INS_NO { get; set; }
        public DateTime INS_DATE { get; set; }
        public decimal INS_AMOUNT { get; set; }
        public DateTime DEPOSIT_DATE { get; set; }
        public string BANK_LOCATION { get; set; }
    }
}
