using Delivery.Request.Service.Application.DeliveryRequests.Commands.Create.Contracts;
using Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Contracts.Create;

namespace Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Converters.Create;

internal static class CreateDeliveryRequestCommandConverter
{
    public static CreateDeliveryRequestCommandInternal ToInternal(CreateDeliveryRequestCommand command)
    {
        var response = new CreateDeliveryRequestCommandInternal(command.Name, command.Description);

        return response;
    }
}
