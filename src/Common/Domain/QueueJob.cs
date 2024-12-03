namespace Common.Domain;

public class QueueJob
{
    public long Id { get; set; }
    public long JobId { get; set; }
    public short Progress { get; set; }
}