using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day33
{
    public class WERTY
    {
        private static Dictionary<char, char> FIXER_DICT = new Dictionary<char,char> {
            {'W' , 'Q'}, {'S' , 'A'}, {'X' , 'Z'}, 
            {'E' , 'W'}, {'D' , 'S'}, {'C' , 'X'}, 
            {'R' , 'E'}, {'F' , 'D'}, {'V' , 'C'}, 
            {'T' , 'R'}, {'G' , 'F'}, {'B' , 'V'}, 
            {'Y' , 'T'}, {'H' , 'G'}, {'N' , 'B'},
            {'U' , 'Y'}, {'J' , 'H'}, {'M' , 'N'},
            {'I' , 'U'}, {'K' , 'J'}, {',' , 'M'},
            {'O' , 'I'}, {'L' , 'K'}, {'.' , ','},
            {'P' , 'O'}, {'Ç' , 'L'}, {';' , '.'},
            {'´' , 'P'}, {' ', ' '}
        };
        public static string KeyboardMistakeFix(string unfixed)
        {
            var sb = new StringBuilder();

            foreach(var it in unfixed.ToUpper().ToCharArray()) {
                bool getValidate = FIXER_DICT.TryGetValue(it, out char fix);

                if(getValidate) {
                    sb.Append(fix);
                }
            }

            return sb.ToString();
        }
    }
}