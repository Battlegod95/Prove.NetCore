using Microsoft.AspNetCore.Mvc;

namespace Prove_dotnet_core.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            //ritornerà il contenuto che gli passo attraverso Content > sono index
            //return Content("Sono Index");
            //ritorna la view impostata dentro la cartella che segue le convenzioni mvc e quindi il nome dell'index
            return View();
        }

        public IActionResult Detail(string id)
        {
            //return Content($"Sono Detail, ho ricevuto l'id {id}");
            return View();
        }
    }
}