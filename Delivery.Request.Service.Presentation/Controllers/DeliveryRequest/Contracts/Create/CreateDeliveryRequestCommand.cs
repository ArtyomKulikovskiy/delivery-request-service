using System;

namespace Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Contracts.Create;

public sealed class CreateDeliveryRequestCommand
{
    public required Guid DeliveryId { get; init; }
    public required string Name { get; init; }
    public required string Description { get; init; }
}
