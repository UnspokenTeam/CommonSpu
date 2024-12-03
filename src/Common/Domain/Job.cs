namespace Common.Domain;

public class Job
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<string> RequestedMetrics { get; set; } = [];
    public List<string>? Report { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}