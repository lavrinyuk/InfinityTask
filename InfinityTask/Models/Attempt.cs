namespace InfinityTask.Models;

public class Attempt
{
    public int AttemptId { get; set; }
    public User User { get; set; }
    public int UserId { get; set; }
    public Question Question { get; set; }
    public int QuestionId { get; set; }
    public string Value { get; set; }
    public bool Verdict { get; set; }
    public DateTimeOffset DateTime { get; set; }
}