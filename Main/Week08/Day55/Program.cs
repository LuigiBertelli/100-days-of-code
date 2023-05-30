using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Text.RegularExpressions;

namespace Day55;

public class Program
{
    static void Main(string[] args)
    {

    }
}

public class RepeatFilter
{
    public static string[] IdenticalFilter(string[] strInput)
    {
        var repeatList = new List<string>();
        Func<string, int, bool> isRepeated = null;
        isRepeated = (string inpt, int cont) => {
            if(inpt.Length == 1)
                return true;

            if(cont > inpt.Length / 2)
                return false;
            
            var rpt = inpt.Substring(0, cont);
            var count = 0;

            foreach(Match m in Regex.Matches(inpt, rpt))
            {
                count++;
            }

            if(inpt.Length % cont == 0 && count == inpt.Length / cont)
                return true;

            return isRepeated(inpt, cont + 1);
        };

        foreach(var str in strInput)
        {
            if(isRepeated(str, 1)) repeatList.Add(str);
        }

        return repeatList.ToArray();
    }
}