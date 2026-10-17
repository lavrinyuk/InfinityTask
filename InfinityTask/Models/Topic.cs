namespace InfinityTask.Models;

public class Topic
{
    public int TopicId { get; set; }
    public string Name { get; set; }
    public List<Question> Questions { get; set; }
}