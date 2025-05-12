namespace Blog.Models.Read;

public class CommentViewModelFactory
{
    public static CommentViewModel Create(Comment post)
    {
        return new CommentViewModel()
        {
            Content = post.Content,
        };
    }

    public static List<CommentViewModel> CreateList(IEnumerable<Comment> comments)
    {
        return comments.Select(Create).ToList();
    }
}