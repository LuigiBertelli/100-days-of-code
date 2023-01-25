using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day25
{
    public class CoinTrouble
    {
        public static bool CoinDiv(int[] coinsArray)
        {
            const int div = 3;

            int sum = coinsArray.Sum();

            if(sum == 0)
                return true;

            if(sum % div == 0) {
                int part = sum / div;

                List<int> coinsList = coinsArray.ToList();
                List<int[]> coinsDivList = new List<int[]>();
                List<int> auxCoins = new List<int>();
                
                while(coinsList.Count() > 0 && coinsDivList.Count() < div) {
                    int curVal = auxCoins.Sum(); 
                    List<int> lst = coinsList.FindAll(x => curVal + x <= part);

                    if(lst.Count() > 0) {
                        int coin = lst.Max();
                        coinsList.Remove(coin);

                        auxCoins.Add(coin);

                        if(curVal + coin == part) {
                            coinsDivList.Add(auxCoins.ToArray());
                            auxCoins = new List<int>();
                        }
                    } else {
                        coinsDivList.Add(auxCoins.ToArray());
                        auxCoins = new List<int>();
                    }
                        
                }

                if(coinsList.Count() == 0 && coinsDivList.Count() == div  && coinsDivList.Sum(x => x.Sum()) == sum)
                    return true;
            }

            return false;
        }
    }
}