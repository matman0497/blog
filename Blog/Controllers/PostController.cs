using Blog.Models;
using Blog.Services;
using Blog.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers;

public class PostController : Controller
{
    private readonly PostService _postService;

    public PostController(PostService postService)
    {
        _postService = postService;
    }

    //GET
    public IActionResult Index()
    {
        var posts = _postService.GetPosts();

        return View(PostViewModelFactory.CreateList(posts));
    }

    //POST
    public IActionResult Create(PostFormModel model)
    {
        if (ModelState.IsValid)
        {
            _postService.CreatePost(model);
            return RedirectToAction("Index");
        }

        return View(model);
    }

    // GET: /Post/Edit/{id}
    [HttpGet]
    public IActionResult Edit(Guid id)
    {
        var model = _postService.FindPost(id);

        var viewModel = new UpdatePostFormModel()
        {
            Content = model.Content,
            Title = model.Title,
            Id = model.Id,
        };

        return View(viewModel);
    }

    // POST: /Post/Edit
    [HttpPost]
    public IActionResult Edit(UpdatePostFormModel model)
    {
        if (ModelState.IsValid)
        {
            _postService.UpdatePost(model);
            return RedirectToAction("Index");
        }

        return View(model);
    }
}