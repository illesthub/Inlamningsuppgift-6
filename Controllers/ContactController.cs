using Microsoft.AspNetCore.Mvc;
namespace Inlamningsuppgift_6.Controllers;

public class ContactController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
