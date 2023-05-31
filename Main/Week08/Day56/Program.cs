using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Day56;

public class Program
{
    static void Main(string[] args)
    {

    }
}

public class HexConverter
{
    public static string ConvertStr2ASCII(string str)
    {
        var ascStr = new List<string>();

        foreach(var c in str.ToCharArray())
        {
            ascStr.Add(Convert.ToHexString(new Byte[] {(byte)c}).ToLower());
        }
     
        return String.Join(" ", ascStr.ToArray());
    }
}