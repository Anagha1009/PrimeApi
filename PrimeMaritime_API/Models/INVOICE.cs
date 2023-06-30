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
        public List<INVOICE_BL_CONTAINER> CONTAINERS { get; set; } = new List<INVOICE_BL_CONTAINER>();
        public List<INVOICE_BL_BRANCH> BRANCH { get; set; } = new List<INVOICE_BL_BRANCH>();
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

    public class INVOICE_MASTER
    {
        public int ID { get; set; }
        public string INVOICE_NO { get; set; }
        public string INVOICE_TYPE { get; set; }
        public string BILL_TO { get; set; }
        public string BILL_FROM { get; set; }
        public string SHIPPER_NAME { get; set; }
        public string PAYMENT_TERM { get; set; }
        public string BL_NO { get; set; }
        public string AGENT_NAME { get; set; }
        public string AGENT_CODE { get; set; }
        public string CREATED_BY { get; set; }
        public string UPDATED_BY { get; set; }
        public bool STATUS { get; set; }
        public string ORG_NAME { get; set; }
        public string ORG_ADDRESS1 { get; set; }
        public DateTime INVOICE_DATE { get; set; }
        public string ADDRESS { get; set; }
        public string TAX_NO { get; set; }
        public string PAN { get; set; }
        public string PLACE_OF_RECEIPT { get; set; }
        public string PLACE_OF_DELIVERY { get; set; }
        public string PORT_OF_LOADING { get; set; }
        public string PORT_OF_DISCHARGE { get; set; }
        public string VESSEL_NAME { get; set; }
        public string VOYAGE_NO { get; set; }
        public string CONTAINERS { get; set; }
        public string CONTAINER_LIST { get; set; }
        public List<INVOICE_CHARGES> BL_LIST { get; set; } = new List<INVOICE_CHARGES>();
    }

    public class INVOICE_CHARGES
    {
        public int ID { get; set; }
        public string INVOICE_NO { get; set; }
        public string CHARGE_NAME { get; set; }
        public decimal EXCHANGE_RATE { get; set; }
        public int QUANTITY { get; set; }
        public decimal AMOUNT { get; set; }
        public string HSN_CODE { get; set; }
        public decimal REQUESTED_AMOUNT { get; set; }
        public string CURRENCY { get; set; }
        public string EXEMPT_FLAG { get; set; }
        public bool IS_SRRCHARGE { get; set; }
        public decimal RATE { get; set; }
        public decimal IGST { get; set; }
        public decimal SGST { get; set; }
        public decimal CGST { get; set; }
    }

    public class INVOICE_BL_CONTAINER
    {
        public int ID { get; set; }
        public string CONTAINER_NO { get; set; }
    }

    public class INVOICE_BL_BRANCH
    {
        public int ID { get; set; }
        public string CUST_NAME { get; set; }
        public string BRANCH_NAME { get; set; }
        public string BRANCH_CODE { get; set; }
        public string COUNTRY { get; set; }
        public string TAX_NO { get; set; }
        public string TAX_TYPE { get; set; }
        public string ADDRESS { get; set; }
        public bool IS_SEZ { get; set; }
        public bool IS_TAX_APPLICABLE { get; set; }

    }
}
