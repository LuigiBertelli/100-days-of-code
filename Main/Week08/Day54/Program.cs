using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Day53
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string rgb = "rgb(0, 128, 192)";
            Console.WriteLine(RGB2HexConverter.RgbToHex(rgb));
        }
    }

    public class RGB2HexConverter
    {

        public static string RgbToHex(string rgb)
        {
            const char charSeparator = ',';
            var sbHex = new StringBuilder("#");

            var rgbSplit = rgb
                .Replace(")", "")
                .Substring(4)
                .Split(charSeparator);
            

            foreach(string it in rgbSplit) 
            {
                var rgbProp = Int32.Parse(it);
                sbHex.Append(rgbProp.ToString("X"));
            }

            return sbHex
                .ToString()
                .ToLower();
        }
    } 
}
