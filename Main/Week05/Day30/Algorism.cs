using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day30
{
    public class Algorism
    {
        public static int Maximum(int num, int digit) {
            string numStr = num.ToString();
            int max = 0;
            int start = num >= 0 ? 0 : 1;
            for(int i = start; i <= numStr.Length; i++) {
                var auxList = numStr.ToList<char>();

                auxList.Insert(i, char.Parse(digit.ToString()));
                bool isParsed = Int32.TryParse(new string(auxList.ToArray<char>()), out int n);

                if(isParsed && (i == start || n > max))
                    max = n;

            }

            return max;
        }
    }
}