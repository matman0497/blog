using Blog.Models;
using Blog.Repositories;

namespace Blog.Services;

public class PostService
{
    IPostRepository _postRepository;

    public PostService(IPostRepository postRepository)
    {
        _postRepository = postRepository;
    }

    public List<Post> GetPosts()
    {
        return _postRepository.All();
    }

    public Post CreatePost(PostFormModel post)
    {
        return _postRepository.Create(post);
    }
    
    public Post UpdatePost(UpdatePostFormModel post)
    {
        return _postRepository.Update(post);
    }

    public Post FindPost(Guid id)
    {
        return _postRepository.GetById(id);
    }

    public void Delete(Guid id)
    {
        _postRepository.Delete(id);
    }
}