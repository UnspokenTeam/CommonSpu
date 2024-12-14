namespace Common.Domain;

public class QueueJob
{
    public long Id { get; set; }
    public long JobId { get; set; }
    public short Progress { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    public Job Job { get; set; }
}