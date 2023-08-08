using MediatR;

namespace Delivery.Request.Service.Application.DeliveryRequests.Commands.Update.Contracts;

public sealed record UpdateDeliveryRequestCommandInternal(Guid Id, string Name, string Description) : IRequest;
