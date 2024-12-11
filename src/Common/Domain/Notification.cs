namespace Common.Domain;

public class Notification
{
    public long Id { get; set; }
    public string Text { get; set; } = string.Empty;
    public int JobId { get; set; }
    public DateTime CreatedAt { get; set; }
    
    public Job Job { get; set; }
    public ICollection<NotificationReceiver> NotificationReceivers { get; set; }
}