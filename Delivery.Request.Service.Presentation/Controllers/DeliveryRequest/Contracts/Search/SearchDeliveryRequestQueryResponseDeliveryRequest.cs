using System;

using Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Enums;

namespace Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Contracts.Search;

public sealed class SearchDeliveryRequestQueryResponseDeliveryRequest
{
    public Guid Id { get; init; }
    public string Name { get; init; }
    public string Description { get; init; }
    public Guid? CourierId { get; init; }
    public DeliveryRequestStatusDto Status { get; init; }
    public string CancellationReason { get; init; }
}
