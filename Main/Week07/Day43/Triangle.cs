using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day43
{
    public class Triangle
    {
        public double TriBase;
        public double TriHeight;

        public double Area {
            get {
                return (TriBase * TriHeight) / 2.0;
            }
        }

        public static void Main(string[] args)
        {
            
        }

        public Triangle(double triBase, double triHeight)
        {
            TriBase = triBase;
            TriHeight = triHeight;
        }
        
    }
}