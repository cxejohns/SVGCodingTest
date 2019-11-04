using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SVGCodingTest.App_Start
{
    public class BarChartController : Controller
    {
        // GET: BarChart
        public ActionResult DrawBarChart()
        {
            return View();
        }
    }
}