using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var read = Console.ReadLine();
            int num = Convert.ToInt32(read);
            int i = new BinarySearchTree().CountUniqueBST(num);

            Console.WriteLine($"{i} possible binary search trees using numbers 1 ... {read}");
        }
    }
}