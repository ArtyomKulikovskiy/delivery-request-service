using System.Linq;

using Delivery.Request.Service.Application.DeliveryRequests.Queries.Search.Contracts;
using Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Contracts.Search;

namespace Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Converters.Search;

internal static class SearchDeliveryRequestQueryResponseConverter
{
    public static SearchDeliveryRequestQueryResponse FromInternal(SearchDeliveryRequestQueryResponseInternal responseInternal)
    {
        var response = new SearchDeliveryRequestQueryResponse
        {
            DeliveryRequests = responseInternal.DeliveryRequests.Select(FromInternal).ToArray()
        };

        return response;
    }

    private static SearchDeliveryRequestQueryResponseDeliveryRequest FromInternal(
        SearchDeliveryRequestQueryResponseInternalDeliveryRequest deliveryRequest)
    {
        var response = new SearchDeliveryRequestQueryResponseDeliveryRequest
        {
            Id = deliveryRequest.Id,
            DeliveryId = deliveryRequest.DeliveryId,
            CancellationReason = deliveryRequest.CancellationReason,
            CourierId = deliveryRequest.CourierId,
            Description = deliveryRequest.Description,
            Name = deliveryRequest.Name,
            Status = DeliveryRequestStatusDtoConverter.FromInternal(deliveryRequest.Status)
        };

        return response;
    }
}
