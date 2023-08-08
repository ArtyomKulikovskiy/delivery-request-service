using System.Reflection;

using Delivery.Request.Service.Application;
using Delivery.Request.Service.Infrastructure;
using Delivery.Request.Service.Presentation.Extensions;
using Delivery.Request.Service.Presentation.Middlewares;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Delivery.Request.Service.Presentation;

internal sealed class Startup
{
    private readonly IConfiguration _configuration;

    public Startup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();

        services.AddEndpointsApiExplorer();

        services.AddSwaggerGen();

        services.AddDbContext<DataContext>(x => x
            .UseNpgsql(_configuration.GetConnectionString("postgres")));

        Assembly[] assemblyNames =
        {
            typeof(IApplicationAssemblyMarker).Assembly
        };

        services.AddMediatR(x => x.RegisterServicesFromAssemblies(assemblyNames));

        InfrastructureRegistrar.Configure(services);
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.EnsureMigrationOfContext<DataContext>();

        app.UseSwagger();

        app.UseSwaggerUI();

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseMiddleware<ExceptionInterceptor>();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
