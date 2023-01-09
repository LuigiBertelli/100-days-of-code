using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string test = "23989";
            var c = Phone.Typing(test);

            foreach(string i in c)
                Console.WriteLine(i);

            Console.WriteLine("Shutting down");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}