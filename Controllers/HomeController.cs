using Microsoft.AspNetCore.Mvc;

namespace Inlamningsuppgift_6.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
