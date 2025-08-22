using Microsoft.AspNetCore.Mvc;

namespace BHD_231230747_22_08_2025.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult indexBook()
        {
            var indexBook = new List<string> { "Lập trình C++", "Cấu trúc dữ liệu và giải thuật", "Overview of ASP.NET Core" };
            return View("indexBook", indexBook);
        }

        public IActionResult Details(string name)
        {
            ViewBag.BookName = name;
            return View("DetailsBook");
        }
    }
}
