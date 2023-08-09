using Delivery.Request.Service.Application.DeliveryRequests.Enums;

namespace Delivery.Request.Service.Application.DeliveryRequests.Queries.GetById.Contracts;

public sealed record GetByIdDeliveryRequestQueryResponseInternal(
    Guid Id,
    Guid DeliveryId,
    string Name,
    string Description,
    Guid? CourierId,
    DeliveryRequestStatusInternal Status,
    string CancellationReason);