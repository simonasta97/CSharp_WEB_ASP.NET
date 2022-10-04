using ForumApp.Data;
using ForumApp.Models;
using Microsoft.AspNetCore.Mvc;
using ForumApp.Data.Entities;

namespace ForumApp.Controllers
{
    public class PostsController : Controller
    {
        private readonly ForumAppDbContext data;

        public PostsController(ForumAppDbContext data)
            => this.data = data;

        public IActionResult Index()
        {
            var posts = this.data.Posts
                .Select(p => new PostViewModel
                {
                    Id = p.Id,
                    Title = p.Title,
                    Content = p.Content
                })
                .ToList();

            return View(posts);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new PostFormModel();

            ViewData["Title"] = "Add new Post";
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(PostFormModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewData["Tilte"] = "Add new Post";
                return View(model);
            }
            var post = new Post() 
            { 
                Title=model.Title,
                Content=model.Content
            };

            this.data.Posts.Add(post);
            this.data.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
