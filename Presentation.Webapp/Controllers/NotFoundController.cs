using Microsoft.AspNetCore.Mvc;

namespace Presentation.Webapp.Controllers;

[Route("404")]

public class NotFoundController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
