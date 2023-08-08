namespace Delivery.Request.Service.Application.DeliveryRequests.Queries.Search.Contracts;

public sealed record SearchDeliveryRequestQueryResponseInternal(
    SearchDeliveryRequestQueryResponseInternalDeliveryRequest[] DeliveryRequests);
