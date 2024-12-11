namespace Common.Domain;

public class JobAttachment
{
    public long Id { get; set; }
    public long JobId { get; set; }
    public string S3FileName { get; set; } = string.Empty;
    public string S3BucketName { get; set; } = string.Empty;
    public AttachmentType Type { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    public Job Job { get; set; }
}