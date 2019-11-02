using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SVGCodingTest.Models
{
    public class Sale // The sale object is a catch-all place to store sales data for a particular vehicle type.
    {
        public int Id { get; set; } // potentially reduntant, since vehicle already has its own id, but it can't hurt

        public Vehicle Vehicle { get; set; } // the vehicle

        public Dictionary<int, int> SalesByYear { get; set; } // The sales data: look up the value of quantity sold using the year as key.



    }
}
