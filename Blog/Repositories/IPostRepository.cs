using Blog.Models;

namespace Blog.Repositories;

public interface IPostRepository
{
    public List<Post> All();
    Post Create(PostFormModel post);
    Post GetById(Guid id);
    Post Update(UpdatePostFormModel post);
}