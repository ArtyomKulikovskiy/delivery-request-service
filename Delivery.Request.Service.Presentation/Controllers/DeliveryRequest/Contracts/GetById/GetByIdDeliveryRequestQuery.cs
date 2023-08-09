using System;

namespace Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Contracts.GetById;

public sealed class GetByIdDeliveryRequestQuery
{
    public required Guid Id { get; init; }
}