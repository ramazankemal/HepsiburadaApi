using Api.Request;
using Api.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.API
{
    public interface IApiHelper
    {
        Task<OrderResponse> GetOrders();
        Task<bool> UpdatePackage(UpdatePackageRequest request);
        Task<bool> UpdateStockAmount(List<UpdateStockAmountRequest> requestList);
    }
}
