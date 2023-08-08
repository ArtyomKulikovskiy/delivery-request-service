using Delivery.Request.Service.Domain.DeliveryRequests;
using Delivery.Request.Service.Infrastructure.Configurations;

using Microsoft.EntityFrameworkCore;

namespace Delivery.Request.Service.Infrastructure;

public sealed class DataContext : DbContext
{
    public DataContext()
    {
    }

    public DataContext(DbContextOptions optionsBuilder) : base(optionsBuilder)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new DeliveryRequestEntityTypeConfiguration());

        base.OnModelCreating(modelBuilder);
    }

    public DbSet<DeliveryRequest> DeliveryRequests { get; set; }
}
