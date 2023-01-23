using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day22
{
    public class Extension
    {
        public static long CalcExtensionInFootballFields(int extension)
        {
            const float FOOTBALL_FIELD_SIZE = (105 * 68) / 1000f;

            return (long) Math.Round(extension / FOOTBALL_FIELD_SIZE);
        }
    }
}