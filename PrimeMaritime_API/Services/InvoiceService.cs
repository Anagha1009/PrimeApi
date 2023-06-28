using Microsoft.Extensions.Configuration;
using PrimeMaritime_API.Helpers;
using PrimeMaritime_API.IServices;
using PrimeMaritime_API.Models;
using PrimeMaritime_API.Repository;
using PrimeMaritime_API.Response;
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
                if (data.Tables.Contains("Table4"))
                {
                    invoiceBL.CONTAINERS = InvoiceRepo.GetListFromDataSet<INVOICE_BL_CONTAINER>(data.Tables[4]);
                }

                if (data.Tables.Contains("Table5"))
                {
                    invoiceBL.BRANCH = InvoiceRepo.GetListFromDataSet<INVOICE_BL_BRANCH>(data.Tables[5]);
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

        public Response<CommonResponse> InsertInvoice(INVOICE_MASTER request)
        {
            string dbConn = _config.GetConnectionString("ConnectionString");

            DbClientFactory<InvoiceRepo>.Instance.InsertInvoice(dbConn, request);

            Response<CommonResponse> response = new Response<CommonResponse>();
            response.Succeeded = true;
            response.ResponseMessage = "Invoice saved Successfully.";
            response.ResponseCode = 200;

            return response;
        }

        public Response<INVOICE_MASTER> GetInvoiceDetails(string INVOICE_NO, string PORT, string ORG_CODE)
        {
            string dbConn = _config.GetConnectionString("ConnectionString");

            Response<INVOICE_MASTER> response = new Response<INVOICE_MASTER>();

            if ((INVOICE_NO == "") || (INVOICE_NO == null))
            {
                response.ResponseCode = 500;
                response.ResponseMessage = "Please provide Invoice No";
                return response;
            }

            var data = DbClientFactory<InvoiceRepo>.Instance.GetInvoiceDetails(dbConn, INVOICE_NO, PORT, ORG_CODE);

            if ((data != null) && (data.Tables[0].Rows.Count > 0))
            {
                response.Succeeded = true;
                response.ResponseCode = 200;
                response.ResponseMessage = "Success";
                INVOICE_MASTER invoice = new INVOICE_MASTER();

                invoice = InvoiceRepo.GetSingleDataFromDataSet<INVOICE_MASTER>(data.Tables[0]);

                response.Data = invoice;
            }
            else
            {
                response.Succeeded = false;
                response.ResponseCode = 500;
                response.ResponseMessage = "No Data";
            }

            return response;
        }
        public Response<List<INVOICE_MASTER>> GetInvoiceList(string FROM_DATE, string TO_DATE, string PORT, string ORG_CODE)
        {
            string dbConn = _config.GetConnectionString("ConnectionString");

            Response<List<INVOICE_MASTER>> response = new Response<List<INVOICE_MASTER>>();
            var data = DbClientFactory<InvoiceRepo>.Instance.GetInvoiceList(dbConn, FROM_DATE, TO_DATE, ORG_CODE, PORT);

            if (data.Count > 0)
            {
                response.Succeeded = true;
                response.ResponseCode = 200;
                response.ResponseMessage = "Success";
                response.Data = data;
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
