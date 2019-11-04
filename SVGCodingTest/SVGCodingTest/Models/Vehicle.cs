using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SVGCodingTest.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public int Sales2018 { get; set; }
        public int Sales2019 { get; set; }
        // add other vehicle data here
        public int YearlyDifference { get
            {
                return Sales2019 - Sales2018;
            } }

        public decimal GetMarketShare2019(SalesReport salesReport)
        {
            foreach (Vehicle vehicle in salesReport.Vehicles)
            {
                if(vehicle.Type == Type)
                {
                    decimal vehicleSales = vehicle.Sales2019;
                    decimal totalSales = salesReport.TotalSold2019;
                    decimal marketShare = vehicleSales / totalSales;
                    marketShare = Math.Round(marketShare, 2);
                    marketShare = marketShare * 100;
                    return marketShare;

                }
            }
            return 0;
        }
    }

}
