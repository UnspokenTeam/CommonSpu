namespace Common.Domain.Read;

public class JobPermission
{
    public long UserId { get; set; }
    public long JobId { get; set; }
    public List<string> Permissions { get; set; } = [];
    public UserToTaskType UserType { get; set; }
    
    public User User { get; set; }
    public Job Job { get; set; }
}