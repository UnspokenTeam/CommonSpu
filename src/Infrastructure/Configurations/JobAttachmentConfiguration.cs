using Common.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class JobAttachmentConfiguration : IEntityTypeConfiguration<JobAttachment>
{
    public void Configure(EntityTypeBuilder<JobAttachment> builder)
    {
        builder.HasKey(entity => entity.Id);

        builder.HasOne(entity => entity.Job)
            .WithMany(entity => entity.JobAttachments)
            .HasForeignKey(entity => entity.Id);
    }
}