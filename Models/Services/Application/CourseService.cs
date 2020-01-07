using Prove_dotnet_core.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prove_dotnet_core.Models.Services.Application
{
    public class CourseService
    {
        public List<CourseViewModel> GetServices()
        {
            var courseList = new List<CourseViewModel>();
            var rand = new Random();
            for (int i = 1; i <= 20; i++)
            {
                var price = Convert.ToDecimal(rand.NextDouble() * 10 + 10);
                var course = new CourseViewModel
                {
                    Id = i,
                    Title = $"Corso {i}",
                    CurrentPrice = Math.Round(price, 2),
                    FullPrice = Math.Round(price, 2),
                    Author = "Nome Cognome",
                    Rating = rand.NextDouble() * 5.0,
                    ImagePath = "/logo.png"
                };
                courseList.Add(course);
            }
            return courseList;
        }
    }
}
