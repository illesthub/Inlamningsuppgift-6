using Inlamningsuppgift_6.Helpers.Repositories;
using Inlamningsuppgift_6.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
namespace Inlamningsuppgift_6.Controllers;

public class ContactController : Controller
{
    private readonly ContactFormRepo _contactFormRepo;

    public ContactController(ContactFormRepo contactFormRepo)
    {
        _contactFormRepo = contactFormRepo;
    }

    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Index(ContactFormViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            await _contactFormRepo.AddAsync(viewModel);
            return RedirectToAction("Index");
        }

        return View(viewModel);
    }
}
