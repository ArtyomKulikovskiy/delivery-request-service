using Delivery.Request.Service.Application.DeliveryRequests.Commands.Delete.Contracts;
using Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Contracts.Delete;

namespace Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Converters.Delete;

internal static class DeleteDeliveryRequestCommandConverter
{
    public static DeleteDeliveryRequestCommandInternal ToInternal(DeleteDeliveryRequestCommand command)
    {
        var response = new DeleteDeliveryRequestCommandInternal(command.Id);

        return response;
    }
}
