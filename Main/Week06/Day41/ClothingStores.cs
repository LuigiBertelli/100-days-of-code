using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day41
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
        }
    }


    public class ClothingStores
    {
        public static int PairOfSocksStock(int[] socks)
        {
            var socksLst = socks.ToList();
            var cont = 0;

            while(socksLst.Count > 0) {
                var sockID = socksLst[0];

                socksLst.RemoveAt(0);

                if(socksLst.Remove(sockID)) {
                    cont++;
                }
            }

            return cont;
        }
    }
}