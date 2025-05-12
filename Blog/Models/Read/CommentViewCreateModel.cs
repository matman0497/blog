using Blog.Models.Write;

namespace Blog.Models.Read;

public class CommentViewCreateModel
{
    public List<CommentViewModel> Comments { get; set; }
    public CommentFormModel NewComment { get; set; }
    public Guid PostId { get; set; }
}