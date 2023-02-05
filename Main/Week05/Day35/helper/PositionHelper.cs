using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day35.helper
{
    public class PositionHelper
    {
        public static double Distance((double x, double y) pos1, (double x, double y) pos2) => Math.Sqrt(Math.Pow((pos1.x - pos2.x), 2d) + Math.Pow((pos1.x - pos2.x), 2d));
    }
}