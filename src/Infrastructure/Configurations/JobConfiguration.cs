using Common.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class JobConfiguration : IEntityTypeConfiguration<Job>
{
    public void Configure(EntityTypeBuilder<Job> builder)
    {
        builder.HasKey(entity => entity.Id);

        builder.HasMany(entity => entity.JobPermissions)
            .WithOne(entity => entity.Job)
            .HasForeignKey(entity => entity.JobId);

        builder.HasMany(entity => entity.JobAttachments)
            .WithOne(entity => entity.Job)
            .HasForeignKey(entity => entity.JobId);

        builder.HasOne(entity => entity.QueueJobs)
            .WithOne(entity => entity.Job)
            .HasForeignKey<QueueJob>(entity => entity.JobId);
    }
}