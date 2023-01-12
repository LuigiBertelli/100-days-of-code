using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Day12
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var sla = new int[]{350, 100, 200, 400, 700};

            Console.WriteLine(Landscape.LandscapeType(sla));
        }
    }
}