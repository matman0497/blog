using Blog.Models;
using Blog.Models.Write;

namespace Blog.Repositories;

public interface ICommentRepository
{
    public List<Comment> GetComments(Guid postId);
    void Add(CommentFormModel model);
}