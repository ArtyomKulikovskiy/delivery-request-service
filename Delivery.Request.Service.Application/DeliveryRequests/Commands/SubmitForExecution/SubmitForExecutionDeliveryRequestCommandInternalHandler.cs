using Delivery.Request.Service.Application.DeliveryRequests.Commands.SubmitForExecution.Contracts;
using Delivery.Request.Service.Infrastructure.Abstractions.DeliveryRequests;

using MediatR;

namespace Delivery.Request.Service.Application.DeliveryRequests.Commands.SubmitForExecution;

internal sealed class SubmitForExecutionDeliveryRequestCommandInternalHandler
    : IRequestHandler<SubmitForExecutionDeliveryRequestCommandInternal>
{
    private readonly IDeliveryRequestRepository _deliveryRequestRepository;

    public SubmitForExecutionDeliveryRequestCommandInternalHandler(IDeliveryRequestRepository deliveryRequestRepository)
    {
        _deliveryRequestRepository = deliveryRequestRepository;
    }

    public async Task Handle(SubmitForExecutionDeliveryRequestCommandInternal request, CancellationToken cancellationToken)
    {
        Domain.DeliveryRequests.DeliveryRequest deliveryRequest = await _deliveryRequestRepository
            .GetById(request.Id, cancellationToken);

        deliveryRequest.SubmitForExecution(request.CourierId);

        await _deliveryRequestRepository.Update(deliveryRequest, cancellationToken);
    }
}
