using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day19
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var sla = Console.ReadLine();
            Console.WriteLine(URLFormatter.URLShortener(sla));
        }
    }
}