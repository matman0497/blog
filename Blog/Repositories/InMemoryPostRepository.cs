using Blog.Models;

namespace Blog.Repositories;

public class InMemoryPostRepository : IPostRepository
{
    private List<Post> _posts = new()
    {
        new Post()
        {
            Title = "Good morning",
            Content =
                "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book."
        },
        new Post()
        {
            Title = "Good morning",
            Content =
                "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book."
        },
        new Post()
        {
            Title = "Good morning",
            Content =
                "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book."
        },
        new Post()
        {
            Title = "Good morning",
            Content =
                "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book."
        },
        new Post()
        {
            Title = "Good morning",
            Content =
                "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book."
        },
        new Post()
        {
            Title = "Good morning",
            Content =
                "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book."
        },
        new Post()
        {
            Title = "Good morning",
            Content =
                "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book."
        },
        new Post()
        {
            Title = "Good morning",
            Content =
                "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book."
        },
        new Post()
        {
            Title = "Good morning",
            Content =
                "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book."
        },
        new Post()
        {
            Title = "Good morning",
            Content =
                "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book."
        },
        new Post()
        {
            Title = "Good morning",
            Content =
                "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book."
        },
        new Post()
        {
            Title = "Good morning",
            Content =
                "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book."
        },
        new Post()
        {
            Title = "Good morning",
            Content =
                "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book."
        },
        new Post()
        {
            Title = "Good morning",
            Content =
                "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book."
        },
        new Post()
        {
            Title = "Good morning",
            Content =
                "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book."
        },
        new Post()
        {
            Title = "Good morning",
            Content =
                "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book."
        },
        new Post()
        {
            Title = "Good morning",
            Content =
                "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book."
        },
        new Post()
        {
            Title = "Good morning",
            Content =
                "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book."
        },
        new Post()
        {
            Title = "Good morning",
            Content =
                "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book."
        }
    };

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