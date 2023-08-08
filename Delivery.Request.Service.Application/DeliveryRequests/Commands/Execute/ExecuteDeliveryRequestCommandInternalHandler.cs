using Delivery.Request.Service.Application.DeliveryRequests.Commands.Execute.Contracts;
using Delivery.Request.Service.Infrastructure.Abstractions.DeliveryRequests;

using MediatR;

namespace Delivery.Request.Service.Application.DeliveryRequests.Commands.Execute;

internal sealed class ExecuteDeliveryRequestCommandInternalHandler : IRequestHandler<ExecuteDeliveryRequestCommandInternal>
{
    private readonly IDeliveryRequestRepository _deliveryRequestRepository;

    public ExecuteDeliveryRequestCommandInternalHandler(IDeliveryRequestRepository deliveryRequestRepository)
    {
        _deliveryRequestRepository = deliveryRequestRepository;
    }

    public async Task Handle(ExecuteDeliveryRequestCommandInternal request, CancellationToken cancellationToken)
    {
        Domain.DeliveryRequests.DeliveryRequest deliveryRequest = await _deliveryRequestRepository
            .GetById(request.Id, cancellationToken);

        deliveryRequest.Execute();

        await _deliveryRequestRepository.Update(deliveryRequest, cancellationToken);
    }
}
