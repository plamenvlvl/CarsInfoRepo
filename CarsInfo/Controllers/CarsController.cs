using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarsInfo.Controllers
{
    public class CarsController : Controller
    {
        // GET: Cars

        public ActionResult GetCars()
        {
            var cars = new List<string> { "car N1", "car N2" };
            return View(cars);
        }

        public ActionResult GetCar(int id)
        {
            string car = "car N1";
            return View(car);
        }

        public ActionResult Index()
        {
            return View();
        }


    }
}