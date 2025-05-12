using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Context;

public class BlogContext : DbContext
{
    protected BlogContext()
    {
    }

    public BlogContext(DbContextOptions<BlogContext> options) : base(options)
    {
    }
    
    public DbSet<Post> Posts { get; set; }
}