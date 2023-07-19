using PrimeMaritime_API.Response;
using PrimeMaritime_API.Helpers;

namespace PrimeMaritime_API.IServices
{
    public interface IReceiptService
    {
        Response<CommonResponse> InsertInvoice();
    }
}
