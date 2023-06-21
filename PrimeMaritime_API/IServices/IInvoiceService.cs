using PrimeMaritime_API.Helpers;
using PrimeMaritime_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeMaritime_API.IServices
{
    public interface IInvoiceService
    {
        Response<INVOICE_BL> GetBLDetails(string BL_NO, string PORT, string ORG_CODE);
    }
}
