using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day49
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
        }
    }

    public class Pool
    {
        public int[][] Backyard {get; private set;}

        public Pool(int[][] backyard)
        {
            Backyard = backyard;
        }

        public bool IsLegitimate()
        {
            int boundLin = Backyard.GetUpperBound(0);

            for(int i = 0; i <= boundLin; i++) {
                var line = Backyard[i];
                if(((i == 0 || i == boundLin) && line.Contains(1)) || line[0] == 1 || line[line.GetUpperBound(0)] == 1) {
                    return false;
                }
            }

            return true;
        }
    }
}