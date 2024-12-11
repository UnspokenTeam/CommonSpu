namespace Common.Domain.Read;

public class NotificationReciever
{
    public long NotificationId { get; set; }
    public Notification Notification { get; set; }
    public long UserId { get; set; }
    public User User { get; set; }
}