namespace Blog.Models;

public class Comment
{
    public Guid Id { get; set; }
    public Guid PostId { get; set; }
    public string Content { get; set; }
    public DateTime Created { get; set; }
}