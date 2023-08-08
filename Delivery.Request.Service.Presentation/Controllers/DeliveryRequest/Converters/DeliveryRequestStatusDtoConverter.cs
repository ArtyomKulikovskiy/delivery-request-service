using System;

using Delivery.Request.Service.Application.DeliveryRequests.Enums;
using Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Enums;

namespace Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Converters;

internal static class DeliveryRequestStatusDtoConverter
{
    public static DeliveryRequestStatusDto FromInternal(DeliveryRequestStatusInternal status)
    {
        DeliveryRequestStatusDto response = status switch
        {
            DeliveryRequestStatusInternal.New => DeliveryRequestStatusDto.New,
            DeliveryRequestStatusInternal.SubmittedForExecution => DeliveryRequestStatusDto.SubmittedForExecution,
            DeliveryRequestStatusInternal.Done => DeliveryRequestStatusDto.Done,
            DeliveryRequestStatusInternal.Canceled => DeliveryRequestStatusDto.Canceled,
            _ => throw new ArgumentOutOfRangeException(nameof(status), status, null)
        };

        return response;
    }
}
