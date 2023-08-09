using Delivery.Request.Service.Application.DeliveryRequests.Queries.GetById.Contracts;
using Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Contracts.GetById;

namespace Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Converters.GetById;

internal static class GetByIdDeliveryRequestQueryResponseConverter
{
    public static GetByIdDeliveryRequestQueryResponse FromInternal(GetByIdDeliveryRequestQueryResponseInternal responseInternal)
    {
        var response = new GetByIdDeliveryRequestQueryResponse
        {
            Id = responseInternal.Id,
            DeliveryId = responseInternal.DeliveryId,
            CancellationReason = responseInternal.CancellationReason,
            CourierId = responseInternal.CourierId,
            Description = responseInternal.Description,
            Name = responseInternal.Name,
            Status = DeliveryRequestStatusDtoConverter.FromInternal(responseInternal.Status)
        };

        return response;
    }
}