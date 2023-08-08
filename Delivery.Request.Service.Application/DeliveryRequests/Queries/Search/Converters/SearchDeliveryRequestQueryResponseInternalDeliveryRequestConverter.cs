using Delivery.Request.Service.Application.DeliveryRequests.Converters;
using Delivery.Request.Service.Application.DeliveryRequests.Enums;
using Delivery.Request.Service.Application.DeliveryRequests.Queries.Search.Contracts;

namespace Delivery.Request.Service.Application.DeliveryRequests.Queries.Search.Converters;

internal static class SearchDeliveryRequestQueryResponseInternalDeliveryRequestConverter
{
    public static SearchDeliveryRequestQueryResponseInternalDeliveryRequest FromDomain(
        Domain.DeliveryRequests.DeliveryRequest deliveryRequest)
    {
        DeliveryRequestStatusInternal status = DeliveryRequestStatusInternalConverter.FromDomain(deliveryRequest.Status);

        var response = new SearchDeliveryRequestQueryResponseInternalDeliveryRequest(
            deliveryRequest.Id,
            deliveryRequest.Name,
            deliveryRequest.Description,
            deliveryRequest.CourierId,
            status,
            deliveryRequest.CancellationReason);

        return response;
    }
}
