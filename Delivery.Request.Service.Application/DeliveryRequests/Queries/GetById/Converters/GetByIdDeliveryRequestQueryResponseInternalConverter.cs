using Delivery.Request.Service.Application.DeliveryRequests.Converters;
using Delivery.Request.Service.Application.DeliveryRequests.Enums;
using Delivery.Request.Service.Application.DeliveryRequests.Queries.GetById.Contracts;

namespace Delivery.Request.Service.Application.DeliveryRequests.Queries.GetById.Converters;

public class GetByIdDeliveryRequestQueryResponseInternalConverter
{
    public static GetByIdDeliveryRequestQueryResponseInternal FromDomain(
        Domain.DeliveryRequests.DeliveryRequest deliveryRequest)
    {
        DeliveryRequestStatusInternal status = DeliveryRequestStatusInternalConverter.FromDomain(deliveryRequest.Status);

        var response = new GetByIdDeliveryRequestQueryResponseInternal(
            deliveryRequest.Id,
            deliveryRequest.DeliveryId,
            deliveryRequest.Name,
            deliveryRequest.Description,
            deliveryRequest.CourierId,
            status,
            deliveryRequest.CancellationReason);

        return response;
    }
}