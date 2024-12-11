namespace Common.Domain.Read;

public class User
{
    public long Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? DeletedAt { get; set; }

    public ICollection<JobPermission> JobPermissions { get; set; }
    public ICollection<Notification> Notifications { get; set; }
}