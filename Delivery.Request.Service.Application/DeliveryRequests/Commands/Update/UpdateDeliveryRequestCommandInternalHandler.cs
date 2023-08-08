using Delivery.Request.Service.Application.DeliveryRequests.Commands.Update.Contracts;
using Delivery.Request.Service.Infrastructure.Abstractions.DeliveryRequests;

using MediatR;

namespace Delivery.Request.Service.Application.DeliveryRequests.Commands.Update;

internal sealed class UpdateDeliveryRequestCommandInternalHandler : IRequestHandler<UpdateDeliveryRequestCommandInternal>
{
    private readonly IDeliveryRequestRepository _deliveryRequestRepository;

    public UpdateDeliveryRequestCommandInternalHandler(IDeliveryRequestRepository deliveryRequestRepository)
    {
        _deliveryRequestRepository = deliveryRequestRepository;
    }

    public async Task Handle(UpdateDeliveryRequestCommandInternal request, CancellationToken cancellationToken)
    {
        Domain.DeliveryRequests.DeliveryRequest deliveryRequest = await _deliveryRequestRepository
            .GetById(request.Id, cancellationToken);

        deliveryRequest.Update(request.Name, request.Description);

        await _deliveryRequestRepository.Update(deliveryRequest, cancellationToken);
    }
}
