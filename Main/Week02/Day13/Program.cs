using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day13
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] test = new int[] {2, 1, 2, 5, 4, 3, 6, 1, 1, 9, 3, 2 };
            int packs = 4;

            Console.WriteLine(Packages.CanFit(test, packs));
        }
    }
}