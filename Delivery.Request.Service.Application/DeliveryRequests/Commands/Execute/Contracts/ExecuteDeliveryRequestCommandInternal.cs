using MediatR;

namespace Delivery.Request.Service.Application.DeliveryRequests.Commands.Execute.Contracts;

public sealed record ExecuteDeliveryRequestCommandInternal(Guid Id) : IRequest;
