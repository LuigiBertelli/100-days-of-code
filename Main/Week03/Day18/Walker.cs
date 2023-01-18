using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day18
{
    public class Walker
    {
        public int _width;
        public int _height;

        public Walker(int m, int n)
        {
            _width = m;
            _height = n;
        }

        /// <summary>A robot is located at the top-left corner of a m x n grid (marked 'Start' in the diagram below).
        /// The robot can only move either down or right at any point in time. The robot is trying to reach the bottom-right corner of the grid (marked 'Finish' in the diagram below).
        /// How many possible unique paths are there?</summary>
        public int UniquePaths()
        {
            int factorialFunc(int x) => x  <= 1 ? 1 : x * factorialFunc(x-1); 

            int totalWalked = _width + _height - 2;

            return factorialFunc(totalWalked) / (factorialFunc(_height - 1) * factorialFunc(_width - 1));
        }
    }
}