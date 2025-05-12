namespace Blog.ViewModels;

public class PostViewModel
{
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public string Content { get; set; } = string.Empty;
    public DateTime LastChange { get; set; }
}