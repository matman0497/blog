using Blog.Models;
using Bogus;

namespace Blog;

public class InMemorySeeder
{
    private List<Post> _posts = new();
    private List<Comment> _comments = new();

    public List<Post> GeneratePosts(int count)
    {
        for (int i = 0; i < count; i++)
        {
            _posts.Add(new Faker<Post>()
                .RuleFor(u => u.Title, f => f.Lorem.Sentence())
                .RuleFor(u => u.Content, f => f.Lorem.Paragraph())
                .RuleFor(u => u.CreatedAt, f => f.Date.Recent(14))
                .Generate());
        }

        return _posts;
    }

    public List<Comment> GenerateComments(int count)
    {
        if (_posts.Count == 0)
        {
            GeneratePosts(10);
        }

        foreach (var post in _posts)
        {
            for (int i = 0; i < count; i++)
            {
                var comment = new Faker<Comment>()
                    .RuleFor(u => u.Content, f => f.Lorem.Sentence())
                    .Generate();
                comment.PostId = post.Id;
                
                _comments.Add(comment);
            }
        }

        return _comments;
    }
}