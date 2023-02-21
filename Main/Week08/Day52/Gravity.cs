using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day52
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[,] blocks = new string[,] {
            {"-", "#", "#", "#", "#", "-"},
            {"#", "-", "-", "#", "#", "-"},
            {"-", "#", "-", "-", "-", "-"},
            {"-", "-", "-", "-", "-", "-"}};


            var actualResult = Gravity.SwitchGravityOn(blocks);
        }
    }

    public class Gravity
    {
        public static string[,] SwitchGravityOn(string[,] blocks)
        {
            for(int col = 0; col <= blocks.GetUpperBound(1); col++) {
                for(int lin = blocks.GetUpperBound(0); lin >= 0; lin--) {
                    if(blocks[lin, col] != "-" && blocks[lin, col] != "#") {
                        blocks[lin, col] = "-";
                    }

                    if(blocks[lin, col] == "#") {
                        int nextLine = lin;

                        while(nextLine < blocks.GetUpperBound(0) && blocks[nextLine + 1, col] != "#") {
                            nextLine++;
                        }

                        if(nextLine != lin) {
                            blocks[lin, col] = "-";
                            blocks[nextLine, col] = "#";
                        }
                    }
                }
            }

            return blocks;
        }        
    }
}