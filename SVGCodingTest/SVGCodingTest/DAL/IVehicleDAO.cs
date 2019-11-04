using SVGCodingTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SVGCodingTest.DAL
{
    public interface IVehicleDAO
    {
        /// <summary>
        /// Gets a single recipe
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Vehicle GetVehicle(int id);

        /// <summary>
        /// Returns all of the recipes
        /// </summary>
        /// <returns></returns>
        IList<Vehicle> GetVehicles();
    }
}
