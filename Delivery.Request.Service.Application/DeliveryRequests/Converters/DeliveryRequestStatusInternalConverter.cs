using Delivery.Request.Service.Application.DeliveryRequests.Enums;
using Delivery.Request.Service.Domain.DeliveryRequests.Enums;

namespace Delivery.Request.Service.Application.DeliveryRequests.Converters;

internal static class DeliveryRequestStatusInternalConverter
{
    public static DeliveryRequestStatusInternal FromDomain(DeliveryRequestStatus status)
    {
        DeliveryRequestStatusInternal response = status switch
        {
            DeliveryRequestStatus.New => DeliveryRequestStatusInternal.New,
            DeliveryRequestStatus.SubmittedForExecution => DeliveryRequestStatusInternal.SubmittedForExecution,
            DeliveryRequestStatus.Done => DeliveryRequestStatusInternal.Done,
            DeliveryRequestStatus.Canceled => DeliveryRequestStatusInternal.Canceled,
            _ => throw new ArgumentOutOfRangeException(nameof(status), status, null)
        };

        return response;
    }
}
