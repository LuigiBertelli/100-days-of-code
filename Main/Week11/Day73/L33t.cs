using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day73
{
    public class L33t
    {
        private static Dictionary<char, string> DICT_LEET = new Dictionary<char, string>() {
            { 'A', @"4" },
            { 'B', @"6" },
            { 'E', @"3" },
            { 'I', @"1" },
            { 'M', @"(V)" },
            { 'N', @"(\)" },
            { 'O', @"0" },
            { 'S', @"5" },
            { 'T', @"7" },
            { 'V', @"\/" },
            { 'W', @"`//" }};

        public static string Translate(string leet)
        {
            foreach(var it in DICT_LEET)
            {
                leet = leet.Replace(it.Value, it.Key.ToString());
            }

            return leet.ToLower();
        }
    }
}
