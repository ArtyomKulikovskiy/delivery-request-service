using Delivery.Request.Service.Domain.DeliveryRequests;
using Delivery.Request.Service.Infrastructure.Abstractions.DeliveryRequests.Contracts;

namespace Delivery.Request.Service.Infrastructure.Abstractions.DeliveryRequests;

public interface IDeliveryRequestRepository
{
    Task<DeliveryRequest[]> Search(SearchDeliveryRequestParams searchParams, CancellationToken cancellationToken);
    Task Insert(DeliveryRequest deliveryRequest, CancellationToken cancellationToken);
    Task<DeliveryRequest> GetById(Guid id, CancellationToken cancellationToken);
    Task Update(DeliveryRequest deliveryRequest, CancellationToken cancellationToken);
}
