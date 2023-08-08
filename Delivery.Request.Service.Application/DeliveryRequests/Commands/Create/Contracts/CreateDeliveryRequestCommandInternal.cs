using MediatR;

namespace Delivery.Request.Service.Application.DeliveryRequests.Commands.Create.Contracts;

public sealed record CreateDeliveryRequestCommandInternal(string Name, string Description)
    : IRequest<CreateDeliveryRequestCommandResponseInternal>;
