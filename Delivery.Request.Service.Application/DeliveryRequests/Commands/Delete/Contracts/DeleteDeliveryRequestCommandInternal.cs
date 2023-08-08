using MediatR;

namespace Delivery.Request.Service.Application.DeliveryRequests.Commands.Delete.Contracts;

public sealed record DeleteDeliveryRequestCommandInternal(Guid Id) : IRequest;
