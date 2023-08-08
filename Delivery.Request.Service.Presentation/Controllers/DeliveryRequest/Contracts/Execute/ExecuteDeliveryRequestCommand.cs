using System;

namespace Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Contracts.Execute;

public sealed class ExecuteDeliveryRequestCommand
{
    public required Guid Id { get; init; }
}
