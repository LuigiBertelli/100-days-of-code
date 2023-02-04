using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day35.helper
{
    public class PositionHelper
    {
        public static double Distance((float x, float y) pos1, (float x, float y) pos2) => Math.Sqrt(Math.Pow((double)(pos1.x - pos2.x), 2d) + Math.Pow((double)(pos1.x - pos2.x), 2d));
    }
}