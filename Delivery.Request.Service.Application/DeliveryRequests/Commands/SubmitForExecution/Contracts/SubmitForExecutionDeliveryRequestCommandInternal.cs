using MediatR;

namespace Delivery.Request.Service.Application.DeliveryRequests.Commands.SubmitForExecution.Contracts;

public sealed record SubmitForExecutionDeliveryRequestCommandInternal(Guid Id, Guid CourierId) : IRequest;
