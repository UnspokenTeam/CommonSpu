namespace Common.Domain.Read;

public class Notification
{
    public long Id { get; set; }
    public string Text { get; set; } = string.Empty;
    public Dictionary<string, object?> Content { get; set; } = new Dictionary<string, object?>();
    
    public ICollection<User> Recievers { get; set; }
}