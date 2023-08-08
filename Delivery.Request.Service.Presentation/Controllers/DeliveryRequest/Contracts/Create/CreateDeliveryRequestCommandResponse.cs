using System;

namespace Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Contracts.Create;

public sealed class CreateDeliveryRequestCommandResponse
{
    public required Guid Id { get; init; }
}
