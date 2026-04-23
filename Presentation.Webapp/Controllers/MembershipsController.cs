using Microsoft.AspNetCore.Mvc;

namespace Presentation.Webapp.Controllers;

public class MembershipsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
