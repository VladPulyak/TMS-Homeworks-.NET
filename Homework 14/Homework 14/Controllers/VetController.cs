using Homework_14.Models;
using Microsoft.AspNetCore.Mvc;

namespace Homework_14.Controllers
{
    public class VetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult VetApplication()
        {
            ModelState.Clear();
            return View();
        }
        [HttpPost]
        public IActionResult VetApplication(DogViewModel dog)
        {
            Console.WriteLine($"Name of your dog:{dog.PetName}");
            Console.WriteLine($"Master name:{dog.HostName}");
            Console.WriteLine($"Age of your dog:{dog.Age}");
            Console.WriteLine($"Weight of your dog:{dog.Weight}");
            return VetApplication();
        }
    }
}
