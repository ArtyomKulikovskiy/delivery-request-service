namespace Delivery.Request.Service.Domain.DeliveryRequests.Enums;

public enum DeliveryRequestStatus
{
    None = 0,
    New = 1,
    SubmittedForExecution = 2,
    Done = 3,
    Canceled = 4
}
