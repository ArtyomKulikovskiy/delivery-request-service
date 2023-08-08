using System;

namespace Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Contracts.Cancel;

public sealed class CancelDeliveryRequestCommand
{
    public required Guid Id { get; init; }
    public required string CancellationReason { get; init; }
}
