using Delivery.Request.Service.Application.DeliveryRequests.Commands.Create.Contracts;
using Delivery.Request.Service.Infrastructure.Abstractions.DeliveryRequests;

using MediatR;

namespace Delivery.Request.Service.Application.DeliveryRequests.Commands.Create;

internal sealed class CreateDeliveryRequestCommandInternalHandler
    : IRequestHandler<CreateDeliveryRequestCommandInternal, CreateDeliveryRequestCommandResponseInternal>
{
    private readonly IDeliveryRequestRepository _deliveryRequestRepository;

    public CreateDeliveryRequestCommandInternalHandler(IDeliveryRequestRepository deliveryRequestRepository)
    {
        _deliveryRequestRepository = deliveryRequestRepository;
    }

    public async Task<CreateDeliveryRequestCommandResponseInternal> Handle(
        CreateDeliveryRequestCommandInternal request,
        CancellationToken cancellationToken)
    {
        var deliveryRequest = Domain.DeliveryRequests.DeliveryRequest.Create(request.Name, request.Description);

        await _deliveryRequestRepository.Insert(deliveryRequest, cancellationToken);

        var response = new CreateDeliveryRequestCommandResponseInternal(deliveryRequest.Id);

        return response;
    }
}
