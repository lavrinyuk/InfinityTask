namespace InfinityTask.Models;

public class Question
{
    public int QuestionId { get; set; }
    public string ProblemStatement { get; set; }
    public string Answer { get; set; }
    public float EloRating { get; set; }
    public Topic Topic { get; set; }
    public int TopicId { get; set; }
}