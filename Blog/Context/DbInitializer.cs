using Blog.Models;

namespace Blog.Context;

public static class DbInitializer
{
    public static void Initialize(BlogContext context, InMemorySeeder inMemorySeeder)
    {
        context.Database.EnsureCreated();

        foreach (var post in inMemorySeeder.GeneratePosts(10))
        {
            context.Posts.Add(post);
        }
        context.SaveChanges();
    }
    
}