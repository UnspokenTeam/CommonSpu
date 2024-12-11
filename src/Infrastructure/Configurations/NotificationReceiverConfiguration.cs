using Common.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class NotificationReceiverConfiguration : IEntityTypeConfiguration<NotificationReceiver>
{
    public void Configure(EntityTypeBuilder<NotificationReceiver> builder)
    {
        builder.HasKey(entity => new { entity.NotificationId, entity.UserId });

        builder.HasOne(entity => entity.Notification)
            .WithMany(entity => entity.NotificationReceivers)
            .HasForeignKey(entity => entity.NotificationId);
    }
}