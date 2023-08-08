using System;

namespace Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Contracts.Update;

public sealed class UpdateDeliveryRequestCommand
{
    public Guid Id { get; init; }
    public string Name { get; init; }
    public string Description { get; init; }
}
