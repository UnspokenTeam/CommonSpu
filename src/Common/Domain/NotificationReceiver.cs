namespace Common.Domain;

public class NotificationReceiver
{
    public long NotificationId { get; set; }
    public long UserId { get; set; }
    public bool IsRead { get; set; }
    public DateTime UpdatedAt { get; set; }
    
    public Notification Notification { get; set; }
    public User User { get; set; }
}