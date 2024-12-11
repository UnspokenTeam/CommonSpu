using Common.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(entity => entity.Id);

        builder.HasMany(entity => entity.JobPermissions)
            .WithOne(entity => entity.User)
            .HasForeignKey(entity => entity.UserId);
        
        builder.HasMany(entity => entity.NotificationReceivers)
            .WithOne(entity => entity.User)
            .HasForeignKey(entity => entity.UserId);
    }
}