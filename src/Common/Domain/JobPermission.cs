namespace Common.Domain;

public class JobPermission
{
    public long UserId { get; set; }
    public long JobId { get; set; }
    public Permission Permissions { get; set; } = null!;
    public UserToTaskType UserType { get; set; }
    
    public User User { get; set; }
    public Job Job { get; set; }
}