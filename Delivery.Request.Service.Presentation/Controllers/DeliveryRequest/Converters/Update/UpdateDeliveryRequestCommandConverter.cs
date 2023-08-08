using Delivery.Request.Service.Application.DeliveryRequests.Commands.Update.Contracts;
using Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Contracts.Update;

namespace Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Converters.Update;

internal static class UpdateDeliveryRequestCommandConverter
{
    public static UpdateDeliveryRequestCommandInternal ToInternal(UpdateDeliveryRequestCommand command)
    {
        var response = new UpdateDeliveryRequestCommandInternal(
            command.Id,
            command.Name,
            command.Description);

        return response;
    }
}
