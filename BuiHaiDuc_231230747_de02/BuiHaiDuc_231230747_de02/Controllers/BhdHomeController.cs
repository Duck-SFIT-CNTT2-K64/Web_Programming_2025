using Microsoft.AspNetCore.Mvc;

namespace BuiHaiDuc_231230747_de02.Controllers
{
    public class BhdHomeController : Controller
    {
        public IActionResult BhdIndex()
        {
            return View();
        }

        public IActionResult BhdAbout()
        {
            return View();
        }
    }
}
