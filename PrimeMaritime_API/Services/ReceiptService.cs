using Microsoft.Extensions.Configuration;
using PrimeMaritime_API.Helpers;
using PrimeMaritime_API.IServices;
using PrimeMaritime_API.Response;

namespace PrimeMaritime_API.Services
{
    public class ReceiptService : IReceiptService
    {
        private readonly IConfiguration _config;
        public ReceiptService(IConfiguration config)
        {
            _config = config;
        }

        public Response<CommonResponse> InsertInvoice()
        {
            throw new System.NotImplementedException();
        }
    }
}
