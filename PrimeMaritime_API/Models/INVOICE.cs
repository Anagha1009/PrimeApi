using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeMaritime_API.Models
{
    public class INVOICE_BL
    {
        public string BL_NO { get; set; }
        public string SHIPPER { get; set; }
        public string ORG_NAME { get; set; }
        public string ORG_ADDRESS1 { get; set; }
        public List<INVOICE_BL_CHARGE> FREIGHT { get; set; } = new List<INVOICE_BL_CHARGE>();
        public List<INVOICE_BL_CHARGE> POL { get; set; } = new List<INVOICE_BL_CHARGE>();
        public List<INVOICE_BL_CHARGE> POD { get; set; } = new List<INVOICE_BL_CHARGE>();
    }

    public class INVOICE_BL_CHARGE
    {
        public string CHARGE_CODE { get; set; }
        public string CURRENCY { get; set; }
        public string PAYMENT_TERM { get; set; }
        public decimal STANDARD_RATE { get; set; }
        public decimal RATE_REQUESTED { get; set; }
        public decimal APPROVED_RATE { get; set; }
    }
}
