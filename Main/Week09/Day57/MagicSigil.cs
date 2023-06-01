using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Day57;

public class MagicSigil
{
    public string DecriptedStr {get; private set;}
    private static char[] constVowels = new char[] {' ', 'A', 'E', 'I', 'O', 'U'};

    public MagicSigil(string decriptedStr)
    {
        this.DecriptedStr = decriptedStr;
    }

    public string Sigilize()
    {
        var strList = new List<char>(DecriptedStr.ToUpper().ToCharArray());
        var cont = 0;
        foreach(var it in constVowels)
        {
            strList.RemoveAll(x => x == it);
        }

        while(cont < strList.Count())
        {
            var cur = strList[cont];
            if(strList.Count(x => x == cur) > 1)
            {
                strList.RemoveAt(cont);
            } else cont++;
        }

        return new String(strList.ToArray());
    }
}