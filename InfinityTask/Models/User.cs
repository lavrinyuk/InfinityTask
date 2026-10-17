namespace InfinityTask.Models;

public class User
{
    public int UserId { get; set; }
    public string Login { get; set; }
    public string PasswordHash { get; set; }
    public float EloRating { get; set; }
    public string Role { get; set; }
}