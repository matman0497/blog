using Blog.Models;

namespace Blog.ViewModels;

public class PostViewModelFactory
{
    public static PostViewModel Create(Post post)
    {
        return new PostViewModel()
        {
            Id = post.Id,
            Title = post.Title,
            Content = post.Content,
            LastChange = post.UpdatedAt ?? post.CreatedAt
        };
    }
    
    public static List<PostViewModel> CreateList(IEnumerable<Post> posts)
    {
        return posts.Select(Create).ToList();
    }
}