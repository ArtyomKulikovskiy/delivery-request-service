using System;

namespace Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Contracts.SubmitForExecution;

public class SubmitForExecutionDeliveryRequestCommand
{
    public Guid Id { get; init; }
    public Guid CourierId { get; init; }
}
