using Microsoft.AspNetCore.Mvc;
using Prove_dotnet_core.Models.Services.Application;
using Prove_dotnet_core.Models.ViewModels;
using System.Collections.Generic;
using Web.Models.ViewModels;

namespace Prove_dotnet_core.Controllers
{
    public class CoursesController : Controller
    {
        private readonly CourseService courseService;

        public CoursesController(CourseService courseService)
        {
            this.courseService = courseService;
        }

        public IActionResult Index()
        {
            //ritornerà il contenuto che gli passo attraverso Content > sono index
            //return Content("Sono Index");
            //ritorna la view impostata dentro la cartella che segue le convenzioni mvc e quindi il nome dell'index

            ViewData["Title"] = "Catalogo dei corsi";
            //var courseService = new CourseService(); //creazione dell'istanza di Courseservice
            List<CourseViewModel> courses = courseService.GetCourses(); //abbiamo invocato l'istanza che serve per ricevere la lista dei corsi
            return View(courses); //gli passiamo l'istanza di courses appena richiamata con il services da presentare nella view
            //se vogliamo predisporre la view per presentare determinati tipi doggetto
        }

        public IActionResult Detail(int id)
        {
           // var courseService = new CourseService();
            CourseDetailViewModel viewModel = courseService.GetCourse(id);
            //return Content($"Sono Detail, ho ricevuto l'id {id}");
            ViewData["Title"] = viewModel.Title;
            return View(viewModel);
        }
    }
}