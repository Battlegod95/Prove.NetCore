using Microsoft.AspNetCore.Mvc;
using Prove_dotnet_core.Models.Services.Application;
using Prove_dotnet_core.Models.ViewModels;
using System.Collections.Generic;

namespace Prove_dotnet_core.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            //ritornerà il contenuto che gli passo attraverso Content > sono index
            //return Content("Sono Index");
            //ritorna la view impostata dentro la cartella che segue le convenzioni mvc e quindi il nome dell'index

            CourseService courseService = new CourseService(); //creazione dell'istanza di Courseservice
            List<CourseViewModel> courses = courseService.GetServices(); //abbiamo invocato l'istanza che serve per ricevere la lista dei corsi
            return View(courses); //gli passiamo l'istanza di courses appena richiamata con il services da presentare nella view

        }

        public IActionResult Detail(string id)
        {
            //return Content($"Sono Detail, ho ricevuto l'id {id}");
            return View();
        }
    }
}