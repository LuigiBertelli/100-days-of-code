using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class Barbecue
    {
        static void Main(string[] args)
        {
        }

        /// <summary>
        ///     Given a Barbecue Grill the function returns the of Vegetarians e Non-Vegetarians skewers
        /// </summary>
        /// <param name="bbqGrill" type="string[]">Barbecue Grill: Each array's item is a skewer</param>
        /// <returns type="int[]">[# vegetarian skewers, # non-vegetarian]</returns>
        public static int[] VegOrNot(string[] bbqGrill)
        {
            int nonVeg = bbqGrill.Where(x => x.Contains("-x")).Count();

            return new int[] { bbqGrill.Count() - nonVeg, nonVeg }; 

        }
    }
}
