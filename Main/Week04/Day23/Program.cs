using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day23.Controllers;

namespace Day23
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var pt = new PhilosophersTable(1);

            int[][] sla = pt.Dining();

            foreach (int[] item in sla)
            {
                foreach (int it in item)
                    Console.Write(it + " ");

                Console.WriteLine("");
            }
        }
    }
}