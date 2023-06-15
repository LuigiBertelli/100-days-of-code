using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day72
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

        public static string Convert(string str) 
        { 
            var leetStr = new StringBuilder("");

            foreach(var letter in str.ToUpper())
            { 
                if(DICT_LEET.ContainsKey(letter)) 
                    leetStr.Append(DICT_LEET[letter]);
                else 
                    leetStr.Append(letter);
            }

            return leetStr.ToString();
        }
    }
}
