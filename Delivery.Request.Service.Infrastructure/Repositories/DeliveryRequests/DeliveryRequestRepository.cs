using Delivery.Request.Service.Domain.DeliveryRequests;
using Delivery.Request.Service.Infrastructure.Abstractions.DeliveryRequests;
using Delivery.Request.Service.Infrastructure.Abstractions.DeliveryRequests.Contracts;

using Microsoft.EntityFrameworkCore;

namespace Delivery.Request.Service.Infrastructure.Repositories.DeliveryRequests;

internal sealed class DeliveryRequestRepository : IDeliveryRequestRepository
{
    private readonly DataContext _dataContext;

    public DeliveryRequestRepository(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public async Task<DeliveryRequest[]> Search(SearchDeliveryRequestParams searchParams, CancellationToken cancellationToken)
    {
        string query = searchParams.Query.ToLower();

        DeliveryRequest[] response = await _dataContext.DeliveryRequests
            .Where(x =>
                x.Description.ToLower().Contains(query) ||
                x.Name.ToLower().Contains(query) ||
                x.CancellationReason.ToLower().Contains(query))
            .ToArrayAsync(cancellationToken);

        return response;
    }

    public async Task Insert(DeliveryRequest deliveryRequest, CancellationToken cancellationToken)
    {
        await _dataContext.AddAsync(deliveryRequest, cancellationToken);

        await _dataContext.SaveChangesAsync(cancellationToken: cancellationToken);
    }

    public async Task<DeliveryRequest> GetById(Guid id, CancellationToken cancellationToken)
    {
        try
        {
            DeliveryRequest response = await _dataContext.DeliveryRequests
                .FirstAsync(x => x.Id == id, cancellationToken: cancellationToken);

            return response;
        }
        catch
        {
            throw new ApplicationException($"Can't find deliveryRequest with Id {id}");
        }
    }

    public async Task Update(DeliveryRequest deliveryRequest, CancellationToken cancellationToken)
    {
        _dataContext.Update(deliveryRequest);

        await _dataContext.SaveChangesAsync(cancellationToken: cancellationToken);
    }
}
