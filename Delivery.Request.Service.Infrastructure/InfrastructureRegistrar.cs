using Delivery.Request.Service.Infrastructure.Abstractions.DeliveryRequests;
using Delivery.Request.Service.Infrastructure.Repositories.DeliveryRequests;

using Microsoft.Extensions.DependencyInjection;

namespace Delivery.Request.Service.Infrastructure;

public static class InfrastructureRegistrar
{
    public static void Configure(IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IDeliveryRequestRepository, DeliveryRequestRepository>();
    }
}
