using PrimeMaritime_API.Helpers;
using PrimeMaritime_API.Models;
using PrimeMaritime_API.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeMaritime_API.IServices
{
    public interface IInvoiceService
    {
        Response<INVOICE_BL> GetBLDetails(string BL_NO, string PORT, string ORG_CODE);
        Response<CommonResponse> InsertInvoice(INVOICE_MASTER request);
        Response<CommonResponse> FinalizeInvoice(INVOICE_FINALIZE request);
        Response<List<INVOICE_MASTER>> GetInvoiceList(string FROM_DATE, string TO_DATE, string PORT, string ORG_CODE, string BL_NO);
        Response<INVOICE_MASTER> GetInvoiceDetails(int INVOICE_ID,string INVOICE_NO, string PORT, string ORG_CODE);
    }
}
