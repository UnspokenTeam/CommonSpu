using Common.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class JobPermissionConfiguration : IEntityTypeConfiguration<JobPermission>
{
    public void Configure(EntityTypeBuilder<JobPermission> builder)
    {
        builder.HasKey(entity => new { entity.JobId, entity.UserId });

        builder.HasOne(entity => entity.Job)
            .WithMany(entity => entity.JobPermissions)
            .HasForeignKey(entity => entity.JobId);
    }
}