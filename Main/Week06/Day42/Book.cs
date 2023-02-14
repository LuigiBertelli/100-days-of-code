using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day42
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
        }
    }

    public class Book
    {
        public static int MinPages(int n, int p)
        {
            int front = (int) Math.Floor(p / 2d);
            int back = (int) Math.Floor((n - p) / 2d);

            return front < back ? front : back;
        }
    }
}