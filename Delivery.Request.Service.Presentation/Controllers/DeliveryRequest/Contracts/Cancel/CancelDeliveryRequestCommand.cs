using System;

namespace Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Contracts.Cancel;

public sealed class CancelDeliveryRequestCommand
{
    public Guid Id { get; init; }
    public string CancellationReason { get; init; }
}
