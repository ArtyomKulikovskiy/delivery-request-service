using Delivery.Request.Service.Application.DeliveryRequests.Commands.Cancel.Contracts;
using Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Contracts.Cancel;

namespace Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Converters.Cancel;

internal static class CancelDeliveryRequestCommandConverter
{
    public static CancelDeliveryRequestCommandInternal ToInternal(CancelDeliveryRequestCommand command)
    {
        var response = new CancelDeliveryRequestCommandInternal(command.Id, command.CancellationReason);

        return response;
    }
}
