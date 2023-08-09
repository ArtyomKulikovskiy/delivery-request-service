using System;

namespace Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Contracts.Search;

public sealed class SearchDeliveryRequestQuery
{
    public string Query { get; init; } = string.Empty;
}
