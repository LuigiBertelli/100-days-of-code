using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day65
{
    public class ISBN
    {
        public static bool Validator(string code)
        {
            try
            {
                var sum = 0;
                int i = 0;

                if (code.Length == 13 && (code[1] != '-' || code[6] != '-' || code[11] != '-')) return false;

                var codeChar = code.Replace("-", "").ToArray();

                if (codeChar.Length != 10) return false;

                for (i = 10; i > 1; i--)
                {
                    sum += Convert.ToInt32(codeChar[10 - i]) * i;
                }

                sum += codeChar[9] == 'X' ? 10 : Convert.ToInt32(codeChar[9]);

                return true;
            } 
            catch
            {
                return false;
            }
        }
    }
}
