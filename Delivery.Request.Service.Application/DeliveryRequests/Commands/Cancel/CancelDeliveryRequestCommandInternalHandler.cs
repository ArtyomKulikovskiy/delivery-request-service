using Delivery.Request.Service.Application.DeliveryRequests.Commands.Cancel.Contracts;
using Delivery.Request.Service.Infrastructure.Abstractions.DeliveryRequests;

using MediatR;

namespace Delivery.Request.Service.Application.DeliveryRequests.Commands.Cancel;

internal sealed class CancelDeliveryRequestCommandInternalHandler : IRequestHandler<CancelDeliveryRequestCommandInternal>
{
    private readonly IDeliveryRequestRepository _deliveryRequestRepository;

    public CancelDeliveryRequestCommandInternalHandler(IDeliveryRequestRepository deliveryRequestRepository)
    {
        _deliveryRequestRepository = deliveryRequestRepository;
    }

    public async Task Handle(CancelDeliveryRequestCommandInternal request, CancellationToken cancellationToken)
    {
        Domain.DeliveryRequests.DeliveryRequest deliveryRequest = await _deliveryRequestRepository
            .GetById(request.Id, cancellationToken);

        deliveryRequest.Cancel(request.CancellationReason);

        await _deliveryRequestRepository.Update(deliveryRequest, cancellationToken);
    }
}
