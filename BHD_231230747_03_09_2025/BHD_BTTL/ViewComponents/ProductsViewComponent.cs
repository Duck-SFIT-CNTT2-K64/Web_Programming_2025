using BHD_BTTL.Models;
using Microsoft.AspNetCore.Mvc;

namespace BHD_BTTL.ViewComponents
{
    public class ProductsViewComponent : ViewComponent
    {
        protected Product product = new Product();

        public IViewComponentResult Invoke()
        {
            var products = product.GetProductList();
            return View(products);
        }
    }
}
