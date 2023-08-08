using Delivery.Request.Service.Application.DeliveryRequests.Queries.Search.Contracts;
using Delivery.Request.Service.Application.DeliveryRequests.Queries.Search.Converters;
using Delivery.Request.Service.Infrastructure.Abstractions.DeliveryRequests;
using Delivery.Request.Service.Infrastructure.Abstractions.DeliveryRequests.Contracts;

using MediatR;

namespace Delivery.Request.Service.Application.DeliveryRequests.Queries.Search;

internal sealed class SearchDeliveryRequestQueryInternalHandler
    : IRequestHandler<SearchDeliveryRequestQueryInternal, SearchDeliveryRequestQueryResponseInternal>
{
    private readonly IDeliveryRequestRepository _deliveryRequestRepository;

    public SearchDeliveryRequestQueryInternalHandler(IDeliveryRequestRepository deliveryRequestRepository)
    {
        _deliveryRequestRepository = deliveryRequestRepository;
    }

    public async Task<SearchDeliveryRequestQueryResponseInternal> Handle(
        SearchDeliveryRequestQueryInternal request,
        CancellationToken cancellationToken)
    {
        var searchParams = new SearchDeliveryRequestParams(request.Query);

        Domain.DeliveryRequests.DeliveryRequest[] deliveryRequests = await _deliveryRequestRepository
            .Search(searchParams, cancellationToken);

        SearchDeliveryRequestQueryResponseInternal response = SearchDeliveryRequestQueryResponseInternalConverter
            .FromDomain(deliveryRequests);

        return response;
    }
}
