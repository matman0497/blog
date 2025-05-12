using Blog.Models;
using Blog.Models.Write;

namespace Blog.Repositories;

internal class InMemoryCommentRepository(InMemorySeeder seeder) : ICommentRepository
{
    private List<Comment> _comments = seeder.GenerateComments(10);

    public List<Comment> GetComments(Guid postId)
    {
        return _comments.Where(x => x.PostId == postId).ToList();
    }

    public void Add(CommentFormModel model)
    {
        _comments.Add(new Comment()
        {
            PostId = model.PostId,
            Content = model.Content,
            
        });
    }
}