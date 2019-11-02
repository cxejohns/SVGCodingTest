using SVGCodingTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SVGCodingTest.DAL
{
    public interface ISaleDAO
    {
        /// <summary>
        /// Gets a single recipe
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Sale GetSale(int id);

        /// <summary>
        /// Returns all of the recipes
        /// </summary>
        /// <returns></returns>
        IList<Sale> GetSales();
    }
}
