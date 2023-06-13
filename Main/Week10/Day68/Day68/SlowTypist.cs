using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day68
{
    public class SlowTypist
    {
        private static Dictionary<char, Tuple<int, int>> DIGIT_POS = new Dictionary<char, Tuple<int, int>>() {
                {'1', new Tuple<int,int>(0,3)},
                {'4', new Tuple<int,int>(0,2)},
                {'7', new Tuple<int,int>(0,1)},
                {'.', new Tuple<int,int>(0,0)},
                {'2', new Tuple<int,int>(1,3)},
                {'5', new Tuple<int,int>(1,2)},
                {'8', new Tuple<int,int>(1,1)},
                {'0', new Tuple<int,int>(1,0)},
                {'3', new Tuple<int,int>(2,3)},
                {'6', new Tuple<int,int>(2,2)},
                {'9', new Tuple<int,int>(2,1)}
            };

        public static string Type(string ip)
        {
            var cm = 0d;
            var ipArray = ip.Where(el => DIGIT_POS.ContainsKey(el)).ToArray();
            var curPos = DIGIT_POS[ipArray[0]];

            for (int i = 1; i < ipArray.Length; i++)
            {
                var next = DIGIT_POS[ipArray[i]];

                cm += Math.Sqrt(Math.Pow(curPos.Item1 - next.Item1, 2) + Math.Pow(curPos.Item2 - next.Item2, 2));
                curPos = next;
            }

            return $"{cm.ToString("n", CultureInfo.CreateSpecificCulture("en-US"))} cm";
        }
    }
}
