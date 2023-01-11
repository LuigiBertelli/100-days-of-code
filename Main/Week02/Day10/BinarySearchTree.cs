using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day10
{
    public class BinarySearchTree
    {

        /// Given n, how many structurally unique BST's (binary search trees) that store values 1 ... n?
        ///<param name="n"> number of values to store </param>
        ///<return> number of structurally unique BST's (binary search trees) that store values 1 ... n </return>
        public int CountUniqueBST(int n)
        {    
            if (n <= 1) {
                return 1;
            } else {
                int r = 0;
                for (int i = 1; i <= n; i++) {
                    r += CountUniqueBST(i - 1) * CountUniqueBST(n - i);
                }
                return r;
            }
        }
    }
}