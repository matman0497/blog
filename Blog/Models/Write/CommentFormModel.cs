namespace Blog.Models.Write;

public class CommentFormModel
{
    public string Content { get; set; } = null!;
    public Guid PostId { get; set; }
}