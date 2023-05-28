using Inlamningsuppgift_6.Helpers.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Inlamningsuppgift_6.Controllers
{
    public class ProductController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProductDetails(int productId)
        {
            return View(productId);
        }
    }
}
