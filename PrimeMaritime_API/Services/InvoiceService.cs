using Microsoft.Extensions.Configuration;
using PrimeMaritime_API.Helpers;
using PrimeMaritime_API.IServices;
using PrimeMaritime_API.Models;
using PrimeMaritime_API.Repository;
using PrimeMaritime_API.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeMaritime_API.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IConfiguration _config;
        public InvoiceService(IConfiguration config)
        {
            _config = config;
        }
        public Response<INVOICE_BL> GetBLDetails(string BL_NO, string PORT, string ORG_CODE)
        {
            string dbConn = _config.GetConnectionString("ConnectionString");

            Response<INVOICE_BL> response = new Response<INVOICE_BL>();

            if ((BL_NO == "") || (BL_NO == null))
            {
                response.ResponseCode = 500;
                response.ResponseMessage = "Please provide BL No";
                return response;
            }

            var data = DbClientFactory<InvoiceRepo>.Instance.GetBLDetails(dbConn, BL_NO, PORT, ORG_CODE);

            if ((data != null) && (data.Tables[0].Rows.Count > 0))
            {
                response.Succeeded = true;
                response.ResponseCode = 200;
                response.ResponseMessage = "Success";
                INVOICE_BL invoiceBL = new INVOICE_BL();

                invoiceBL = InvoiceRepo.GetSingleDataFromDataSet<INVOICE_BL>(data.Tables[0]);

                if (data.Tables.Contains("Table1"))
                {
                    invoiceBL.FREIGHT = InvoiceRepo.GetListFromDataSet<INVOICE_BL_CHARGE>(data.Tables[1]);
                }

                if (data.Tables.Contains("Table2"))
                {
                    invoiceBL.POL = InvoiceRepo.GetListFromDataSet<INVOICE_BL_CHARGE>(data.Tables[2]);
                }

                if (data.Tables.Contains("Table3"))
                {
                    invoiceBL.POD = InvoiceRepo.GetListFromDataSet<INVOICE_BL_CHARGE>(data.Tables[3]);
                }

                response.Data = invoiceBL;
            }
            else
            {
                response.Succeeded = false;
                response.ResponseCode = 500;
                response.ResponseMessage = "No Data";
            }

            return response;
        }
    }
}
