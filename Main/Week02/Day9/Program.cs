using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string j = "0";
            List<int> list = new List<int>();
            while(!String.IsNullOrEmpty(j)){
                j = Console.ReadLine();
                Int32.TryParse(j, out int i);
                if(Int32.IsPositive(i))
                    list.Add(i);
            }

            var result = Rain.TrappingRainWater(list.ToArray());
            Console.WriteLine(result);
        }
    }
    
}