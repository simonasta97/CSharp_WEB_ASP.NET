using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Watchlist.Models;

namespace Watchlist.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("All", "Movies");
            }

            return View();
        }
    }
}