using System;

namespace Day38
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Number: ");
            var num = 0;
            if(!Int32.TryParse(Console.ReadLine(), out num))
                return;

            Console.Write("S: ");
            var s = 0;
            if(!Int32.TryParse(Console.ReadLine(), out s))
                return;

            Console.WriteLine(DisplayLCD.ToLCD(num, s));
        }
    }
}