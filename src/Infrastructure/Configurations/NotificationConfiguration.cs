using Common.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class NotificationConfiguration : IEntityTypeConfiguration<Notification>
{
    public void Configure(EntityTypeBuilder<Notification> builder)
    {
        builder.HasKey(entity => entity.Id);

        builder.HasMany(entity => entity.NotificationReceivers)
            .WithOne(entity => entity.Notification)
            .HasForeignKey(entity => entity.NotificationId);
    }
}