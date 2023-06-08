using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day64
{
    public class Recursing
    {
        public static char First(string str)
        {
            var strList = new List<char>(str.ToUpper().ToArray());

            while (strList.Count() > 0)
            {
                var cur = strList.First();

                if(strList.Count(x => x == cur) > 1) return cur;
            }

            return ' ';
        }
    }
}
