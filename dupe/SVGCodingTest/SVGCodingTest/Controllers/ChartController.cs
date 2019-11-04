using SVGCodingTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SVGCodingTest.App_Start
{
    public class ChartController : Controller
    {
        public SalesReport ExampleReport = new SalesReport()
        {
            Vehicles = new List<Vehicle>()
            {
                new Vehicle() { Id = 1, Type = "Bicycle", Sales2018 = 200, Sales2019 = 220 },
                new Vehicle() { Id = 2, Type = "Car", Sales2018 = 100, Sales2019 = 94 },
                new Vehicle() { Id = 3, Type = "Truck", Sales2018 = 150, Sales2019 = 168 },
                new Vehicle() { Id = 4, Type = "Motorcycle", Sales2018 = 40, Sales2019 = 55 },
                new Vehicle() { Id = 5, Type = "Jet", Sales2018 = 11, Sales2019 = 14 }
            }
        };

        public ActionResult Sales()
        {
            return View(ExampleReport);
        }
        public ActionResult MarketShare()
        {
            return View(ExampleReport);
        }
    }
}