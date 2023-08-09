using MediatR;

namespace Delivery.Request.Service.Application.DeliveryRequests.Queries.GetById.Contracts;

public sealed record GetByIdDeliveryRequestQueryInternal(Guid Id) : IRequest<GetByIdDeliveryRequestQueryResponseInternal>;