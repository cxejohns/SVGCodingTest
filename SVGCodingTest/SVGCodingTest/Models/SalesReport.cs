using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SVGCodingTest.Models
{
    public class SalesReport // The SalesReport object is a catch-all place to store sales data for a particular vehicle type.
    {
        public List<Vehicle> Vehicles {get; set;}

        public int TotalSold2019 { get
            {
                var total = 0;
                foreach (Vehicle vehicle in Vehicles)
                {
                    total = total + vehicle.Sales2019;
                }
                return total;
            } }

    }
}
