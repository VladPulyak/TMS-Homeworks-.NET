using FishesWebMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FishesWebMVC.Controllers
{
    public class HomeController : Controller
    {
        private Fish[] fishes = new Fish[]
        {
            new Fish("Карп", 5, 4),
            new Fish("Карась", 3, 7),
            new Fish("Осетр", 10, 5)
        };
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PrintWithViewData()
        {
            ViewData["Fishes"] = fishes;
            return View();
        }
        public IActionResult PrintWithViewBag()
        {
            ViewBag.Fishes = fishes;
            return View();
        }
        public IActionResult PrintWIthModels()
        {
            ViewData["NewName"] = "Плотва";
            ViewBag.NewWeight = 999;
            return View(fishes);
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