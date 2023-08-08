using Delivery.Request.Service.Application.DeliveryRequests.Commands.SubmitForExecution.Contracts;
using Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Contracts.SubmitForExecution;

namespace Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Converters.SubmitForExecution;

internal static class SubmitForExecutionDeliveryRequestCommandConverter
{
    public static SubmitForExecutionDeliveryRequestCommandInternal ToInternal(SubmitForExecutionDeliveryRequestCommand command)
    {
        var response = new SubmitForExecutionDeliveryRequestCommandInternal(command.Id, command.CourierId);

        return response;
    }
}
