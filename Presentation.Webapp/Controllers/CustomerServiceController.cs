using Microsoft.AspNetCore.Mvc;

namespace Presentation.Webapp.Controllers
{
    public class CustomerServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
