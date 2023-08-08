using Delivery.Request.Service.Application.DeliveryRequests.Commands.Delete.Contracts;
using Delivery.Request.Service.Infrastructure.Abstractions.DeliveryRequests;

using MediatR;

namespace Delivery.Request.Service.Application.DeliveryRequests.Commands.Delete;

internal sealed class DeleteDeliveryRequestCommandInternalHandler : IRequestHandler<DeleteDeliveryRequestCommandInternal>
{
    private readonly IDeliveryRequestRepository _deliveryRequestRepository;

    public DeleteDeliveryRequestCommandInternalHandler(IDeliveryRequestRepository deliveryRequestRepository)
    {
        _deliveryRequestRepository = deliveryRequestRepository;
    }

    public async Task Handle(DeleteDeliveryRequestCommandInternal request, CancellationToken cancellationToken)
    {
        Domain.DeliveryRequests.DeliveryRequest deliveryRequest = await _deliveryRequestRepository
            .GetById(request.Id, cancellationToken);

        deliveryRequest.Delete();

        await _deliveryRequestRepository.Update(deliveryRequest, cancellationToken);
    }
}
