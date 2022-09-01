using Homework_13.Models;
using Microsoft.AspNetCore.Mvc;

namespace Homework_13.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            BookViewModel book = new BookViewModel("Mumu", "Tyrgenev", 600);
            return View(book);
        }
    }
}
