using System;

namespace Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Contracts.Delete;

public sealed class DeleteDeliveryRequestCommand
{
    public required Guid Id { get; init; }
}
