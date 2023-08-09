using MediatR;

namespace Delivery.Request.Service.Application.DeliveryRequests.Commands.Create.Contracts;

public sealed record CreateDeliveryRequestCommandInternal(Guid DeliveryId, string Name, string Description)
    : IRequest<CreateDeliveryRequestCommandResponseInternal>;
