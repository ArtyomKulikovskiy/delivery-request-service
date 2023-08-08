using Delivery.Request.Service.Application.DeliveryRequests.Queries.Search.Contracts;
using Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Contracts.Search;

namespace Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Converters.Search;

internal static class SearchDeliveryRequestQueryConverter
{
    public static SearchDeliveryRequestQueryInternal ToInternal(SearchDeliveryRequestQuery query)
    {
        var response = new SearchDeliveryRequestQueryInternal(query.Query);

        return response;
    }
}
