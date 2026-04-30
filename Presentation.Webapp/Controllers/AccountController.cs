using Microsoft.AspNetCore.Mvc;

namespace Presentation.Webapp.Controllers;

public class AccountController : Controller
{
    public IActionResult My()
    {
        return View();
    }
}
