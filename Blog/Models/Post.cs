namespace Blog.Models;

public class Post
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public required string Title { get; set; }
    public string Content { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? UpdatedAt { get; set; }
}