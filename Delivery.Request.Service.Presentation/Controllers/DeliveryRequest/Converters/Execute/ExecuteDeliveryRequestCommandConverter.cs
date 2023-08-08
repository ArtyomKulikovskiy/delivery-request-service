using Delivery.Request.Service.Application.DeliveryRequests.Commands.Execute.Contracts;
using Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Contracts.Execute;

namespace Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Converters.Execute;

internal static class ExecuteDeliveryRequestCommandConverter
{
    public static ExecuteDeliveryRequestCommandInternal ToInternal(ExecuteDeliveryRequestCommand command)
    {
        var response = new ExecuteDeliveryRequestCommandInternal(command.Id);

        return response;
    }
}
