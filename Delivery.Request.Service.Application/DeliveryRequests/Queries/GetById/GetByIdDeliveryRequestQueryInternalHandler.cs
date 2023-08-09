using Delivery.Request.Service.Application.DeliveryRequests.Queries.GetById.Contracts;
using Delivery.Request.Service.Application.DeliveryRequests.Queries.GetById.Converters;
using Delivery.Request.Service.Domain.DeliveryRequests;
using Delivery.Request.Service.Infrastructure.Abstractions.DeliveryRequests;
using MediatR;

namespace Delivery.Request.Service.Application.DeliveryRequests.Queries.GetById;

public class GetByIdDeliveryRequestQueryInternalHandler 
    : IRequestHandler<GetByIdDeliveryRequestQueryInternal, GetByIdDeliveryRequestQueryResponseInternal>
{
    private readonly IDeliveryRequestRepository _deliveryRequestRepository;

    public GetByIdDeliveryRequestQueryInternalHandler(IDeliveryRequestRepository deliveryRequestRepository)
    {
        _deliveryRequestRepository = deliveryRequestRepository;
    }

    public async Task<GetByIdDeliveryRequestQueryResponseInternal> Handle(
        GetByIdDeliveryRequestQueryInternal request,
        CancellationToken cancellationToken)
    {
        DeliveryRequest deliveryRequest = await _deliveryRequestRepository.GetById(request.Id, cancellationToken);

        GetByIdDeliveryRequestQueryResponseInternal responseInternal =
            GetByIdDeliveryRequestQueryResponseInternalConverter.FromDomain(deliveryRequest);

        return responseInternal;
    }
}