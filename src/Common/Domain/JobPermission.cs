namespace Common.Domain;

public class JobPermission
{
    public long UserId { get; set; }
    public long TaskId { get; set; }
    public List<string> Permissions { get; set; } = [];
    public UserToTaskType UserType { get; set; }
}