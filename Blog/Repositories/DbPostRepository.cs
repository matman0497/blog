using Blog.Context;
using Blog.Models;

namespace Blog.Repositories;

public class DbPostRepository(BlogContext context) : IPostRepository
{
    private BlogContext _context = context;

    public List<Post> All()
    {
        return _context.Posts.ToList();
    }

    public Post Create(PostFormModel post)
    {
        throw new NotImplementedException();
    }

    public Post GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Post Update(UpdatePostFormModel post)
    {
        throw new NotImplementedException();
    }

    public void Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}