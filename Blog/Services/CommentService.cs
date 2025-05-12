using Blog.Models;
using Blog.Models.Write;
using Blog.Repositories;

namespace Blog.Services;

public class CommentService(ICommentRepository commentRepository)
{
    private ICommentRepository _commentRepository = commentRepository;

    public List<Comment> GetComments(Guid id)
    {
        return _commentRepository.GetComments(id);
    }

    public void AddComment(CommentFormModel model)
    {
        _commentRepository.Add(model);
    }
}