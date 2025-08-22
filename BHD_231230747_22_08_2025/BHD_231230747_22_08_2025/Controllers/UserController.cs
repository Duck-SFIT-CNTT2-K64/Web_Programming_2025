using Microsoft.AspNetCore.Mvc;

namespace BHD_231230747_22_08_2025.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var users = new List<string> { "Hải Đức Bùi", "Việt Tùng Hồ", "Khúc Nam Phương" };
            return View("UserIndex", users);
        }

        public IActionResult Profile(string name)
        {
            ViewBag.Name = name;
            return View("Profile");
        }
    }
}
