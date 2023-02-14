using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day45
{
    public class BitHandler
    {
        public static void Main(string[] args)
        {
            Console.Write("N1: ");
            if(int.TryParse(Console.ReadLine(), out int n1)) {
                Console.Write("N2: ");
                if(int.TryParse(Console.ReadLine(), out int n2)) {
                    Console.WriteLine($"{n1} XOR {n2} = {XOR(n1, n2)}");
                }
            }
        }

        public static int XOR(int n1, int n2)
        {
            n1 = n1 ^ n2;
            n2 = n1 ^ n2;
            n1 = n1 ^ n2;
            return n1 - n2;
        }
    }
}