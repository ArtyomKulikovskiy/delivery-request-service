using System;
using System.ComponentModel.DataAnnotations;

namespace Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Contracts.SubmitForExecution;

public sealed class SubmitForExecutionDeliveryRequestCommand
{
    public required Guid Id { get; init; }
    public required Guid CourierId { get; init; }
}
