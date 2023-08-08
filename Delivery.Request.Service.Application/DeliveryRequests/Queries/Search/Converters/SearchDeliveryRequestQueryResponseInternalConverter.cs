using Delivery.Request.Service.Application.DeliveryRequests.Queries.Search.Contracts;

namespace Delivery.Request.Service.Application.DeliveryRequests.Queries.Search.Converters;

internal static class SearchDeliveryRequestQueryResponseInternalConverter
{
    public static SearchDeliveryRequestQueryResponseInternal FromDomain(Domain.DeliveryRequests.DeliveryRequest[] deliveryRequests)
    {
        SearchDeliveryRequestQueryResponseInternalDeliveryRequest[] internalDeliveryRequests = deliveryRequests
            .Select(SearchDeliveryRequestQueryResponseInternalDeliveryRequestConverter.FromDomain)
            .ToArray();

        var response = new SearchDeliveryRequestQueryResponseInternal(internalDeliveryRequests);

        return response;
    }
}
