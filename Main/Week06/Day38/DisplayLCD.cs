using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Day38
{
    class NumberLCD 
    {
        public List<string> lcdNumber = new List<string>();
        public NumberLCD(string numberStr, int s)
        {
            var sbTop = new StringBuilder();

            switch(numberStr){
                case "1":
                case "4":
                    sbTop.Append(' ', s + 2);
                    lcdNumber.Add(sbTop.ToString());
                    break;
                default:
                    sbTop.Append(' ');
                    sbTop.Append('-', s);
                    sbTop.Append(' ');
                    lcdNumber.Add(sbTop.ToString());
                    break;
            }

            for(int i = 0; i < s; i++) {
                var sbTopMid = new StringBuilder();
                switch(numberStr){
                    case "1":
                    case "2":
                    case "3":
                    case "7":
                        sbTopMid.Append(' ', s + 1);
                        sbTopMid.Append('|');
                        lcdNumber.Add(sbTopMid.ToString());
                        break;
                    case "5":
                    case "6":
                        sbTopMid.Append('|');
                        sbTopMid.Append(' ', s + 1);
                        lcdNumber.Add(sbTopMid.ToString());
                        break;
                    default:
                        sbTopMid.Append('|');
                        sbTopMid.Append(' ', s);
                        sbTopMid.Append('|');
                        lcdNumber.Add(sbTopMid.ToString());
                        break;
                }
            }

            var sbMid = new StringBuilder();
            switch(numberStr){
                case "0":
                case "1":
                case "7":
                    sbMid.Append(' ', s + 2);
                    lcdNumber.Add(sbMid.ToString());
                    break;
                default:
                    sbMid.Append(' ');
                    sbMid.Append('-', s);
                    sbMid.Append(' ');
                    lcdNumber.Add(sbMid.ToString());
                    break;
            }

            for(int j = 0; j < s; j++) {
                var sbMidBottom = new StringBuilder();
                switch(numberStr){
                    case "6":
                    case "8":
                    case "0":
                        sbMidBottom.Append('|');
                        sbMidBottom.Append(' ', s);
                        sbMidBottom.Append('|');
                        lcdNumber.Add(sbMidBottom.ToString());
                        break;
                    case "2":
                        sbMidBottom.Append('|');
                        sbMidBottom.Append(' ', s + 1);
                        lcdNumber.Add(sbMidBottom.ToString());
                        break;
                    default:
                        sbMidBottom.Append(' ', s + 1);
                        sbMidBottom.Append('|');
                        lcdNumber.Add(sbMidBottom.ToString());
                        break;
                        
                }
            }

            var sbBottom = new StringBuilder();
            switch(numberStr){
                case "1":
                case "4":
                case "7":
                    sbBottom.Append(' ', s + 2);
                    lcdNumber.Add(sbBottom.ToString());
                    break;
                default:
                    sbBottom.Append(' ');
                    sbBottom.Append('-', s);
                    sbBottom.Append(' ');
                    lcdNumber.Add(sbBottom.ToString());
                    break;
            }
        }
    }

    public class DisplayLCD
    {
        public static string ToLCD(int num, int s)
        {
            var numStr = num.ToString();
            var lines = new string[s * 2 + 3];

            for(int i = 0; i < numStr.Length; i++) {
                var numLCD = new NumberLCD(numStr[i].ToString(), s);

                for(int j = 0; j < s * 2 + 3; j++) {
                    var sb = new StringBuilder(lines[j]);
                    sb.Append(numLCD.lcdNumber[j] + " ");

                    lines[j] = sb.ToString();
                }
            }

            return string.Join('\n', lines.ToArray());
        }
    }
}