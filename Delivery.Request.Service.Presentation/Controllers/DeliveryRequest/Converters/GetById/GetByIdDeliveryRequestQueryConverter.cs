using Delivery.Request.Service.Application.DeliveryRequests.Queries.GetById.Contracts;
using Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Contracts.GetById;

namespace Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Converters.GetById;

internal static class GetByIdDeliveryRequestQueryConverter
{
    public static GetByIdDeliveryRequestQueryInternal ToInternal(GetByIdDeliveryRequestQuery query)
    {
        var response = new GetByIdDeliveryRequestQueryInternal(query.Id);

        return response;
    }
}