using System;

namespace Day34
{
    public class Program
    {
        public static void Main(string[] args)
        {   
            Console.Write("N1: ");
            var x = Console.ReadLine();
            var parsed1 = Int32.TryParse(x, out int n1);

            Console.Write("N2: ");
            var y = Console.ReadLine();
            var parsed2 = Int32.TryParse(y, out int n2);

            if(parsed1 && parsed2)
                Console.WriteLine($"Carries on sum: {Calculator.CarryOnSum(n1,n2)}");
        }
    }
}