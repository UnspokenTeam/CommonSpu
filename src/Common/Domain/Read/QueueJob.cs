namespace Common.Domain.Read;

public class QueueJob
{
    public long Id { get; set; }
    public long JobId { get; set; }
    public short Progress { get; set; }
    
    public Job Job { get; set; }
}