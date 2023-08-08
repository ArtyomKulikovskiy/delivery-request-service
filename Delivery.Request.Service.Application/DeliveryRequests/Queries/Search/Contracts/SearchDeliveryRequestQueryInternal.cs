using MediatR;

namespace Delivery.Request.Service.Application.DeliveryRequests.Queries.Search.Contracts;

public sealed record SearchDeliveryRequestQueryInternal(string Query) : IRequest<SearchDeliveryRequestQueryResponseInternal>;
