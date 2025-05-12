using Blog.Models;

namespace Blog.Repositories;

public class InMemoryPostRepository(InMemorySeeder seeder) : IPostRepository
{
    private List<Post> _posts = seeder.GeneratePosts(10);

    public List<Post> All()
    {
        return _posts;
    }

    public Post Create(PostFormModel post)
    {
        var newPost = new Post()
        {
            Content = post.Content,
            Title = post.Title
        };
        _posts.Add(newPost);

        return newPost;
    }

    public Post GetById(Guid id)
    {
        return _posts.First(x => x.Id == id);
    }

    public Post Update(UpdatePostFormModel post)
    {
        var postToUpdate = _posts.First(x => x.Id == post.Id);

        postToUpdate.Content = post.Content;
        postToUpdate.Title = post.Title;
        postToUpdate.UpdatedAt = DateTime.Now;

        return postToUpdate;
    }

    public void Delete(Guid id)
    {
        _posts.Remove(_posts.First(x => x.Id == id));
    }
}