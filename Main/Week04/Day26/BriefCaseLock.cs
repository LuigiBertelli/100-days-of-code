using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day26
{
    public class BriefCaseLock
    {
        public static int MinTurns(string num1, string num2)
        {
            short TurnsForward(short n1, short n2) => (short) (n1 <= n2 ? (n2 - n1) : ((10 - n1) + n2));

            short TurnsBack(short n1, short n2) => (short) (n2 <= n1 ? (n1 - n2) : ((10 - n2) + n1));

            int turns = 0;

            if(num1.Length == num2.Length) {
                for(int i = 0; i < num1.Length; i++) {
                    var forward = TurnsForward(Convert.ToInt16(num1[i]), Convert.ToInt16(num2[i]));
                    var back = TurnsBack(Convert.ToInt16(num1[i]), Convert.ToInt16(num2[i]));

                    turns += forward <= back ? (int) forward : (int) back;
                }
            }

            return turns;
        }
        
    }
}