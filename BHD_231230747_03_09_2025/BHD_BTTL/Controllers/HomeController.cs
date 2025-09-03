using System.Diagnostics;
using BHD_BTTL.Models;
using Microsoft.AspNetCore.Mvc;

namespace BHD_BTTL.Controllers
{
    public class HomeController : Controller
    {
        protected Product product = new Product();

        public IActionResult Index()
        {
            var products = product.GetProductList();
            return View(products);
        }
    }
}
