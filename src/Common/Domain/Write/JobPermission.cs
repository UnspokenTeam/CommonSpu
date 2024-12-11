namespace Common.Domain.Write;

public class JobPermission
{
    public long UserId { get; set; }
    public long JobId { get; set; }
    public List<string> Permissions { get; set; } = [];
    public UserToTaskType UserType { get; set; }
}