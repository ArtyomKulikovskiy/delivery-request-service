using Delivery.Request.Service.Presentation;

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

CreateWebHostBuilder(args).Build().Run();

static IHostBuilder CreateWebHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(webBuilder =>
        {
            webBuilder.UseStartup<Startup>();
        });
