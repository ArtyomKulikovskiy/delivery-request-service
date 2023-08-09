using Delivery.Request.Service.Domain.DeliveryRequests;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Delivery.Request.Service.Infrastructure.Configurations;

internal sealed class DeliveryRequestEntityTypeConfiguration : IEntityTypeConfiguration<DeliveryRequest>
{
    public void Configure(EntityTypeBuilder<DeliveryRequest> builder)
    {
        builder
            .Property(x => x.Status)
            .IsRequired();

        builder.Property(x => x.DeliveryId)
            .IsRequired();

        builder
            .HasKey(x => x.Id);

        builder.
            HasQueryFilter(p => !p.IsDeleted);
    }
}
