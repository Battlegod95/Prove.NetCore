using Microsoft.AspNetCore.Mvc;

namespace Prove_dotnet_core.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return Content("Sono la index della Home");
            return View();
        }
    }
}