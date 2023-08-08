namespace Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Contracts.Create;

public sealed class CreateDeliveryRequestCommand
{
    public string Name { get; init; }
    public string Description { get; init; }
}
