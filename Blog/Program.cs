using Blog;
using Blog.Context;
using Blog.Repositories;
using Blog.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BlogContext>(opts =>
    opts.UseSqlite(builder.Configuration.GetConnectionString("Db")));


// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IPostRepository, DbPostRepository>();
builder.Services.AddSingleton<ICommentRepository, InMemoryCommentRepository>();
builder.Services.AddScoped<PostService>();
builder.Services.AddSingleton<CommentService>();
builder.Services.AddSingleton<InMemorySeeder>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    DbInitializer.Initialize(scope.ServiceProvider.GetRequiredService<BlogContext>(),
        scope.ServiceProvider.GetRequiredService<InMemorySeeder>());
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Post}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();