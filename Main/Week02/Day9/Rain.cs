using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day9
{
    public class Rain
    {
        public static int TrappingRainWater(int[] height)
        {
            var heightList = new List<int>(height);
            int maxHeight =height.OrderBy(x => -x).Where(x => x > 0).ElementAt(0);
            int cont = 0;

            for(int j = maxHeight; j >= 1; j--){
                int countActualHeight = height.Count(x => x >= j);
                int antInd = heightList.FindIndex(x => x >= j);

                for(int i = 1; i < countActualHeight; i++) {
                    int actualInd = heightList.FindIndex( antInd + 1, x => (x >= j) );

                    if(actualInd > antInd + 1)
                        cont += actualInd - 1 - antInd;

                    antInd = actualInd;
                }
            }

            return cont;
        }
    }
}