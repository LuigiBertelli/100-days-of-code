using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day24
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Josephus js = new Josephus(41);

            Console.WriteLine(js.WillRemain(3));
        }
    }
}