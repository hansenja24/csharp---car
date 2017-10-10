using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Cars.Models;


namespace Cars.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Index()
        {
          return View();
        }

        [Route("/car/list")]
        public ActionResult CarList()
        {
          List<string> allCars = Car.GetAll();
          return View(allCars);
        }
        [HttpPost("/car/add")]
        public ActionResult AddCar()
        {
          Car newCar = new Car (Request.Form["carModel"],Request.Form["carPrice"],Request.Form["carMiles"]);
          newCar.Save();
          return View(newCar);
        }
    }
}
