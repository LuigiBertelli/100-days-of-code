using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day25
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var test = new int[]{2, 4, 3, 2, 4, 9, 7, 8, 6, 9};

            Console.WriteLine(CoinTrouble.CoinDiv(test));
        }
    }
}