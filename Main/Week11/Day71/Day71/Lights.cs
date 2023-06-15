using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day71
{
    public class Lights
    {
        public static int TimesOn(int[][] time)
        {
            var start = time[0][0];
            var end = time[0][1];

            foreach (var t in time)
            {
                if (t[0] < start)
                    start = t[0];

                if (t[1] > end)
                    end = t[1];
            }

            return end - start;
        }
    }
}
