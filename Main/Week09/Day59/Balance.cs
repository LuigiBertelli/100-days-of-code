using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Day59;

public class Balance
{
    public static bool BalancedBonus(string str)
    {
        var strCharList = new List<char>(str.ToCharArray());
        var cur = strCharList.FirstOrDefault();
        var cont = strCharList.Count(x => x == cur);


        while(strCharList.Count() > 0)
        {
            if(strCharList.Count(x => x == cur) != cont) return false;

            strCharList.RemoveAll(y => y == cur);
            cur = strCharList.FirstOrDefault();
        }

        return true;
    }
}