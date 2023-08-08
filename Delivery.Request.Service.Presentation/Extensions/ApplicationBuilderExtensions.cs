using System;
using System.Linq;

using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Delivery.Request.Service.Presentation.Extensions;

internal static class ApplicationBuilderExtensions
{
    public static IApplicationBuilder EnsureMigrationOfContext<T>(this IApplicationBuilder app)
        where T : DbContext
    {
        if (app == default)
        {
            throw new ArgumentNullException(nameof(app));
        }

        using IServiceScope scope = app.ApplicationServices.CreateScope();

        var context = scope.ServiceProvider.GetService<T>();

        if (context is null)
        {
            Console.WriteLine("context is null");
            return app;
        }

        string[] migrations = context.Database.GetPendingMigrations().ToArray();

        if (!migrations.Any())
        {
            Console.WriteLine("Database is up to date");
            return app;
        }

        Console.WriteLine($"Apply migrations: {string.Join(", ", migrations)}");

        context.Database.Migrate();

        return app;
    }
}
