﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeMaritime_API.Models
{
    public class PARTY_MASTER
    {
        public int CUST_ID { get; set; }
        public string CUST_NAME { get; set; }
        public string CUST_ADDRESS { get; set; }
        public string CUST_EMAIL { get; set; }
        public string CUST_CONTACT { get; set; }
        public string CUST_TYPE { get; set; }
        public string GSTIN { get; set; }
        public string VAT_NO { get; set; }
        public bool STATUS { get; set; }
        public string REMARKS { get; set; }
        public string AGENT_CODE { get; set; }
        public string CREATED_BY { get; set; }
        public string COUNTRY { get; set; }
        public string STATE { get; set; }
        public string CITY { get; set; }
        public string PINCODE { get; set; }
        public string PAN { get; set; }
        public string CONTACT_PERSON_NAME { get; set; }
        public string CONTACT_PERSON_NO { get; set; }
        public bool IS_GROUP_COMPANIES { get; set; }
        public string SALES_NAME { get; set; }
        public string SALES_CODE { get; set; }
        public string SALES_LOC { get; set; }
        public string SALES_EFFECTIVE_DATE { get; set; }       
        public bool IS_VENDOR { get; set; }
        public List<CUSTOMER_BRANCH> BRANCH_LIST { get; set; } = new List<CUSTOMER_BRANCH>();
        public List<CUSTOMER_BANK> BANK_LIST { get; set; } = new List<CUSTOMER_BANK>();
    }
    public class CUSTOMER_BRANCH
    {
        public int ID { get; set; }
        public int CUST_ID { get; set; }
        public string BRANCH_NAME { get; set; }
        public string BRANCH_CODE { get; set; }
        public string COUNTRY { get; set; }
        public string STATE { get; set; }
        public string CITY { get; set; }
        public string TAN { get; set; }
        public string TAX_NO { get; set; }
        public string TAX_TYPE { get; set; }
        public string PIC_NAME { get; set; }
        public string PIC_CONTACT { get; set; }
        public string PIC_EMAIL { get; set; }
        public string ADDRESS { get; set; }
        public bool IS_SEZ { get; set; }
        public bool IS_TAX_APPLICABLE { get; set; }
        public string ORG_CODE { get; set; }
    }
    public class CUSTOMER_BANK
    {
        public int ID { get; set; }
        public int CUST_ID { get; set; }
        public string BRANCH_CODE { get; set; }
        public string BANK_NAME { get; set; }
        public string BANK_ACC_NO { get; set; }
        public string BANK_IFSC { get; set; }
        public string BANK_SWIFT { get; set; }
        public string BANK_REMARKS { get; set; }
    }
    public class CONTAINER_MASTER
    {
        public int ID { get; set; }
        public string CONTAINER_NO { get; set; }
        public string CONTAINER_TYPE { get; set; }
        public DateTime ONHIRE_DATE { get; set; }      
        public string ONHIRE_LOCATION { get; set; }      
        public string LEASED_FROM { get; set; }      
        public bool STATUS { get; set; }
    }
    public class COUNTRY_MASTER
    {
        public int ID { get; set; }
        public int CODE { get; set; }
        public string NAME { get; set; }
        public string SHORT_NAME { get; set; }
        public bool STATUS { get; set; }
        public string CREATED_BY { get; set; }
    }
    public class STATE_MASTER
    {
        public int ID { get; set; }
        public int CODE { get; set; }
        public string NAME { get; set; }
        public string SHORT_NAME { get; set; }
        public int COUNTRY_ID { get; set; }
        public string COUNTRY_NAME { get; set; }
        List<COUNTRY_MASTER> COUNTRIES { get; set; } = new List<COUNTRY_MASTER>();
        public bool IS_UT { get; set; }
        public bool STATUS { get; set; }
        public string CREATED_BY { get; set; }
    }
    public class MASTER
    {
        public int ID { get; set; }
        public string KEY_NAME { get; set; }
        public string CODE { get; set; }
        public string CODE_DESC { get; set; }
        public Boolean STATUS { get; set; }
        public string PARENT_CODE { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime? CREATED_DATE { get; set; } = null;
        public string UPDATED_BY { get; set; }
        public DateTime? UPDATED_DATE { get; set; } = null;
    }
    public class VESSEL_MASTER
    {
        public int ID { get; set; }
        public string VESSEL_NAME { get; set; }
        public string IMO_NO { get; set; }
        public string COUNTRY_CODE { get; set; }
        public string VESSEL_CODE { get; set; }
        public Boolean STATUS { get; set; }
        public string CREATED_BY { get; set; }

        //public DateTime CREATED_ON { get; set; }

        //public string UPDATED_BY { get; set; }

        //public DateTime UPDATED_DATE { get; set; }
    }
    public class SERVICE_MASTER
    {
        public int ID { get; set; }
        public string LINER_CODE { get; set; }
        public string SERVICE_NAME { get; set; }
        public string PORT_CODE { get; set; }
        public Boolean STATUS { get; set; }
        public string CREATED_BY { get; set; }
    }
    public class CONTAINER_TYPE
    {
        public int ID { get; set; }
        public string CONT_TYPE_CODE { get; set; }
        public string CONT_TYPE { get; set; }
        public int CONT_SIZE { get; set; }
        public string ISO_CODE { get; set; }
        public int TEUS { get; set; }
        public string OUT_DIM { get; set; }
        public Boolean STATUS { get; set; }
        public string CREATED_BY { get; set; }
    }
    public class ICD_MASTER
    {
        public int ID { get; set; }
        public string LOC_NAME { get; set; }
        public string LOC_CODE { get; set; }
        public string LOC_TYPE { get; set; }
        public string ADDRESS { get; set; }
        public string COUNTRY_CODE { get; set; }
        public string ASSOCIATE_PORT_CODE { get; set; }
        public bool LOC_TYPE_STATUS { get; set; }
        public DateTime CREATED_DATE { get; set; }
    }
    public class DEPO_MASTER
    {
        public int ID { get; set; }
        public string LOC_NAME { get; set; }
        public string LOC_CODE { get; set; }
        public string LOC_TYPE { get; set; }
        public string ADDRESS { get; set; }
        public string COUNTRY_CODE { get; set; }
        public string ASSOCIATE_PORT_CODE { get; set; }
        public string LOC_TYPE_STATUS { get; set; }
        public DateTime CREATED_DATE { get; set; }
    }
    public class TERMINAL_MASTER
    {
        public int ID { get; set; }
        public string LOC_NAME { get; set; }
        public string LOC_CODE { get; set; }
        public string LOC_TYPE { get; set; }
        public string ADDRESS { get; set; }
        public string COUNTRY_CODE { get; set; }
        public string ASSOCIATE_PORT_CODE { get; set; }
        public bool LOC_TYPE_STATUS { get; set; }
        public DateTime CREATED_DATE { get; set; }
    }
    public class LINER
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public string CODE { get; set; }
        public string DESCRIPTION { get; set; }
        public Boolean STATUS { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public string CREATED_BY { get; set; }
        public string UPDATED_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }
    }
    public class SERVICE
    {
        public int ID { get; set; }
        public String LINER_CODE { get; set; }
        public String SERVICE_NAME { get; set; }
        public String PORT_CODE { get; set; }
        public Boolean STATUS { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public string CREATED_BY { get; set; }
        public string UPDATED_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }
    }
    public class SCHEDULE
    {
        public int ID { get; set; }
        public string VESSEL_NAME { get; set; }
        public string SERVICE_NAME { get; set; }
        public string PORT_CODE { get; set; }
        public string VIA_NO { get; set; }
        public DateTime ETA { get; set; }
        public DateTime ETD { get; set; }
        public Boolean STATUS { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public string CREATED_BY { get; set; }
        public string UPDATED_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }
    }
    public class LOCATION_MASTER
    {
        public int ID { get; set; }
        public string LOC_NAME { get; set; }
        public string LOC_CODE { get; set; }
        public bool IS_DEPO { get; set; }
        public bool IS_CFS { get; set; }
        public bool IS_TERMINAL { get; set; }
        public bool IS_YARD { get; set; }
        public bool IS_ICD { get; set; }
        public string ADDRESS { get; set; }
        public string COUNTRY_CODE { get; set; }
        public string PORT_CODE { get; set; }
        public bool STATUS { get; set; }
        public DateTime CREATED_DATE { get; set; }     
        public string CREATED_BY { get; set; }
    }
    public class FREIGHT_MASTER
    {
        public int ID { get; set; }
        public string POL { get; set; }
        public string POD { get; set; }
        public string Charge { get; set; }
        public string Currency { get; set; }
        public string LadenStatus { get; set; }
        public string ServiceMode { get; set; }
        public decimal DRY20 { get; set; }
        public decimal DRY40 { get; set; }
        public decimal DRY40HC { get; set; }
        public decimal DRY45 { get; set; }
        public decimal RF20 { get; set; }
        public decimal RF40 { get; set; }
        public decimal RF40HC { get; set; }
        public decimal RF45 { get; set; }
        public decimal HAZ20 { get; set; }
        public decimal HAZ40 { get; set; }
        public decimal HAZ40HC { get; set; }
        public decimal HAZ45 { get; set; }
        public decimal SEQ20 { get; set; }
        public decimal SEQ40 { get; set; }
        public List<CHARGE_MASTER> CHARGELIST { get; set; } = new List<CHARGE_MASTER>();
    }
    public class CHARGE_MASTER
    {
        public int ID { get; set; }
        public string POL { get; set; }
        public string POD { get; set; }
        public string CHARGE_CODE { get; set; }
        public string CURRENCY { get; set; }
        public decimal IMPCOST20 { get; set; }
        public decimal IMPCOST40 { get; set; }
        public decimal IMPINCOME20 { get; set; }
        public decimal IMPINCOME40 { get; set; }
        public decimal EXPCOST20 { get; set; }
        public decimal EXPCOST40 { get; set; }
        public decimal EXPINCOME20 { get; set; }
        public decimal EXPINCOME40 { get; set; }
        public int FROM_VAL { get; set; }
        public int TO_VAL { get; set; }
        public bool STATUS { get; set; }
    }
    public class STEV_MASTER
    {
        public int ID { get; set; }
        public string IE_TYPE { get; set; }
        public string POL { get; set; }
        public string TERMINAL { get; set; }
        public string CHARGE_CODE { get; set; }
        public string CURRENCY { get; set; }
        public string LADEN_STATUS { get; set; }
        public string SERVICE_MODE { get; set; }
        public decimal DRY20 { get; set; }
        public decimal DRY40 { get; set; }
        public decimal DRY40HC { get; set; }
        public decimal DRY45 { get; set; }
        public decimal RF20 { get; set; }
        public decimal RF40 { get; set; }
        public decimal RF40HC { get; set; }
        public decimal RF45 { get; set; }
        public decimal HAZ20 { get; set; }
        public decimal HAZ40 { get; set; }
        public decimal HAZ40HC { get; set; }
        public decimal HAZ45 { get; set; }
        public decimal SEQ20 { get; set; }
        public decimal SEQ40 { get; set; }
    }
    public class DETENTION_MASTER
    {
        public int ID { get; set; }
        public string PORT_CODE { get; set; }
        public string CONTAINER_TYPE { get; set; }
        public string CURRENCY { get; set; }
        public int FROM_DAYS { get; set; }
        public int TO_DAYS { get; set; }
        public decimal RATE20 { get; set; }
        public decimal RATE40 { get; set; }
        public decimal HC_RATE { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime CREATED_DATE { get; set; }
    }
    public class MANDATORY_MASTER
    {
        public int ID { get; set; }
        public string PORT_CODE { get; set; }
        public string ORG_CODE { get; set; }
        public string CHARGE_CODE { get; set; }
        public string IE_TYPE { get; set; }
        public string LADEN_STATUS { get; set; }
        public string CURRENCY { get; set; }
        public decimal RATE20 { get; set; }
        public decimal RATE40 { get; set; }
        public bool IS_PERCENTAGE { get; set; }
        public int PERCENTAGE_VALUE { get; set; }
    }
    public class ORG_MASTER
    {
        public int ID { get; set; }
        public string ORG_NAME { get; set; }
        public string ORG_CODE { get; set; }
        public bool STATUS { get; set; }
        public string PAN { get; set; }
        public string CONTACT_PERSON_NAME { get; set; }
        public string CONTACT_PERSON_NO { get; set; }
        public bool IS_GROUP_COMPANIES { get; set; }
        public string SALES_NAME { get; set; }
        public string SALES_CODE { get; set; }
        public string SALES_LOC { get; set; }
        public string SALES_EFFECTIVE_DATE { get; set; }
        public string CREATED_BY { get; set; }
        public string BRANCH { get; set; }
        public string BANK { get; set; }
        public List<CUSTOMER_BRANCH> BRANCH_LIST { get; set; } = new List<CUSTOMER_BRANCH>();
        public List<CUSTOMER_BANK> BANK_LIST { get; set; } = new List<CUSTOMER_BANK>();
    }
    public class SLOT_MASTER
    {
        public int ID { get; set; }
        public string SLOT_OPERATOR { get; set; }
        public string SERVICES { get; set; }
        public string LINER_CODE { get; set; }
        public string PORT_CODE { get; set; }
        public string TERM { get; set; }
        public bool STATUS { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime CREATED_DATE { get; set; }

        public string ADDRESS { get; set; }

        public string CONTACT { get; set; }

        public string EMAIL { get; set; }

        public string SLOT_CODE { get; set; }
    }
    public class CHARGES_MASTER
    {
        public int ID { get; set; }

        public string CHARGE_NAME { get; set; }

        public string CHARGE_HEADER { get; set; }

        public string APPLICABLE_FOR { get; set; }

        public int GST_PERCENTAGE { get; set; }

        public string CURRENCY { get; set; }

        public string HSN_CODE { get; set; }

        public int CHARGE_AMOUNT { get; set; }

        public string CHARGE_TYPE { get; set; }

        public bool IS_GST { get; set; }
    }
    public class HSN_MASTER
    {
        public int ID { get; set; }
        public string HSN_CODE { get; set; }
        public string HSN_DESC { get; set; }
        public string CREATED_BY { get; set; }
        public decimal RATE { get; set; }
        public decimal IGST { get; set; }
        public decimal CGST { get; set; }
        public decimal SGST { get; set; }
        public string EFFECTIVE_FROM { get; set; }
        public string EFFECTIVE_TO { get; set; }
    }
}
