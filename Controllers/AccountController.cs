using Microsoft.AspNetCore.Mvc;

namespace Inlamningsuppgift_6.Controllers;

public class AccountController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }
}
