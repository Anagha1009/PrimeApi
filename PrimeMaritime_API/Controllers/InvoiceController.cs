using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PrimeMaritime_API.Helpers;
using PrimeMaritime_API.IServices;
using PrimeMaritime_API.Models;
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
    }
}
