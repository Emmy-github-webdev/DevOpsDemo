using DevOpsDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using DevOpsDemo.Repository;

namespace DevOpsDemo.Controllers
{
    public class HomeController : Controller
    {
        IPostRepository PostRepository;

        public HomeController(IPostRepository _PostRepository)
        {
            PostRepository = _PostRepository;
        }

        public IActionResult Index()
        {
            var model = PostRepository.GetPosts();
            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}