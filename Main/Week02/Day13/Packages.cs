using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day13
{
    public class Packages
    {
        private const int max = 10;

        public static bool CanFit(int[] itemsWeight, int packagesNumber)
        {
            List<int> extraWeight = new List<int>();
            int contPacks = 0;
            int curPack = 0;

            foreach(int item in itemsWeight) {
                curPack += item;

                if(curPack == max) {
                    contPacks++;
                    curPack = 0;
                } else if(curPack > max) {
                    extraWeight.Add(curPack - max);
                    curPack = 0;
                    contPacks++;
                }
            }

            if (extraWeight.Count > 0) 
                contPacks++;

            foreach(int extra in extraWeight) {
                curPack += extra;

                if(curPack >= max) {
                    contPacks++;
                    curPack = 0;
                }
            }

            return contPacks <= packagesNumber;
        }
    }
}