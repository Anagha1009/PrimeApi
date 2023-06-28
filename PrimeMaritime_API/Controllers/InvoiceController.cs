using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PrimeMaritime_API.Helpers;
using PrimeMaritime_API.IServices;
using PrimeMaritime_API.Models;
using PrimeMaritime_API.Response;
using PrimeMaritime_API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeMaritime_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private IInvoiceService _invoiceService;
        private readonly IWebHostEnvironment _environment;
        public InvoiceController(IInvoiceService invoiceService, IWebHostEnvironment environment)
        {
            _invoiceService = invoiceService;
            _environment = environment;
        }

        [HttpGet("GetInvoiceBLDetails")]
        public ActionResult<Response<INVOICE_BL>> GetInvoiceBLDetails(string BL_NO, string PORT, string ORG_CODE)
        {
            return Ok(JsonConvert.SerializeObject(_invoiceService.GetBLDetails(BL_NO, PORT, ORG_CODE)));
        }

        [HttpPost("InsertInvoice")]
        public ActionResult<Response<CommonResponse>> InsertInvoice(INVOICE_MASTER request)
        {
            return Ok(_invoiceService.InsertInvoice(request));
        }

        [HttpGet("GetInvoiceList")]
        public ActionResult<Response<List<INVOICE_MASTER>>> GetInvoiceList(string FROM_DATE, string TO_DATE, string PORT, string ORG_CODE)
        {
            return Ok(JsonConvert.SerializeObject(_invoiceService.GetInvoiceList(FROM_DATE, TO_DATE, PORT, ORG_CODE)));
        }

        [HttpGet("GetInvoiceDetails")]
        public ActionResult<Response<INVOICE_MASTER>> GetInvoiceDetails(string INVOICE_NO, string PORT, string ORG_CODE)
        {
            return Ok(JsonConvert.SerializeObject(_invoiceService.GetInvoiceDetails(INVOICE_NO, PORT, ORG_CODE)));
        }

    }
}
