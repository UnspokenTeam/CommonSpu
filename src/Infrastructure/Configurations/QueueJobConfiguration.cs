using Common.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class QueueJobConfiguration : IEntityTypeConfiguration<QueueJob>
{
    public void Configure(EntityTypeBuilder<Common.Domain.QueueJob> builder)
    {
        builder.HasKey(entity => entity.Id);

        builder.HasOne(entity => entity.Job)
            .WithOne(entity => entity.QueueJobs)
            .HasForeignKey<QueueJob>(entity => entity.Id);
    }
}