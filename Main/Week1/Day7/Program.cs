using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day7 {
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] test1 = new int[7]{1,2,3,0,0,0,0};
            int[] test2 = new int[4]{1,2,3,5};

            ArraysHandler.mergeSortedArraysV2(ref test1, test2);
            foreach(int i in test1){
                Console.WriteLine(i);
            }

            Console.WriteLine("Shutting down");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
    
}