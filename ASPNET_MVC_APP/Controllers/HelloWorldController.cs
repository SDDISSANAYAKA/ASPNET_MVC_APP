using ASPNET_MVC_APP.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET_MVC_APP.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogs = new List<DogViewModel>();
        public IActionResult Index()
        {
            //DogViewModel doggo = new DogViewModel()
            //{ Name = "Sif", Age = 2 };
            //return View(doggo);

            return View(dogs);
        }

        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View();
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            //return View("Index");
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }

        public String Hello()
        {
            return "Who's there?";
        }
    }
}
