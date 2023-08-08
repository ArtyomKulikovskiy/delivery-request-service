using System;

namespace Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Contracts.Update;

public sealed class UpdateDeliveryRequestCommand
{
    public required Guid Id { get; init; }
    public required string Name { get; init; }
    public required string Description { get; init; }
}
