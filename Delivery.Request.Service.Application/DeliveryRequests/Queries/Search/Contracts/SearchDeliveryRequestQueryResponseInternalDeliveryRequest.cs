using Delivery.Request.Service.Application.DeliveryRequests.Enums;

namespace Delivery.Request.Service.Application.DeliveryRequests.Queries.Search.Contracts;

public sealed record SearchDeliveryRequestQueryResponseInternalDeliveryRequest(
    Guid Id,
    Guid DeliveryId,
    string Name,
    string Description,
    Guid? CourierId,
    DeliveryRequestStatusInternal Status,
    string CancellationReason);
