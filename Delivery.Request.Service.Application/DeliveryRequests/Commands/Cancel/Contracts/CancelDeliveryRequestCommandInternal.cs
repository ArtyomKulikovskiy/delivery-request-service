using MediatR;

namespace Delivery.Request.Service.Application.DeliveryRequests.Commands.Cancel.Contracts;

public sealed record CancelDeliveryRequestCommandInternal(Guid Id, string CancellationReason) : IRequest;
