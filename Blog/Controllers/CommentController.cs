using Blog.Models;
using Blog.Models.Read;
using Blog.Models.Write;
using Blog.Services;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers;

public class CommentController(CommentService commentService) : Controller
{
    public IActionResult Index(Guid id)
    {
        var comments = commentService.GetComments(id);

        return View(new CommentViewCreateModel() { Comments = CommentViewModelFactory.CreateList(comments), PostId = id});
    }

    //POST
    [HttpPost]
    public IActionResult Create(CommentViewCreateModel model)
    {
        commentService.AddComment(model.NewComment);

        return RedirectToAction("Index", new { id = model.NewComment.PostId });
    }
}