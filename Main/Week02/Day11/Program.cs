using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string test = Console.ReadLine();

            foreach(string ran in IPAddress.AllValidIPs(test))
                Console.WriteLine(ran);

        }
    }
}