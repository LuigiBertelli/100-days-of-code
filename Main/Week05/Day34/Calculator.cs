using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day34
{
    public class Calculator
    {
        public static int CarryOnSum(int n1, int n2) 
        {
            var num1Lst = n1.ToString().ToCharArray().ToList();
            var num2Lst = n2.ToString().ToCharArray().ToList();
            var gap = num1Lst.Count - num2Lst.Count;
            var carry = 0;

            for(int i = 0; i < Math.Abs(gap) && gap != 0; i++) {
                if(gap > 0) {
                    num2Lst.Insert(0, '0');
                } else if(gap < 0) {
                    num1Lst.Insert(0, '0');
                }
            }

            for(int j = num1Lst.Count - 1; j >= 0; j--) {
                int n1It = Int32.Parse(num1Lst[j].ToString());
                int n2It = Int32.Parse(num2Lst[j].ToString());
                if(n1It + n2It >= 10) {
                    if(j > 0){
                        num1Lst[j - 1] = char.Parse((Int32.Parse(num1Lst[j - 1].ToString()) + 1).ToString());
                    }

                    carry++;
                }
            }

            return carry;
        }
    }
}