using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Type a number: ");

            bool success = Int32.TryParse(Console.ReadLine(), out int nextPrime);
            Console.WriteLine($"Next Prime number is: {PrimeNumbers.NextPrime(nextPrime)}");

            Console.WriteLine("Shutting down");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
    
}