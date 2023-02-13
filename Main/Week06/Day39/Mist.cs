using System;
using System.Linq;
using System.Text;
using System.Collections;

namespace Day39
{
    public class Mist
    {
        public static void Main(string[] args)
        {
            
        }

        public static short HowManyGames(double normalPrice, double discount, double minPrice, double budget)
        {
            short cont = 0;
            var curPrice = normalPrice;
            var curAmount = budget;

            while(curPrice >= minPrice && curPrice <= curAmount){
                curAmount -= curPrice;
                curPrice -= discount;
                cont++;
            }

            if(curAmount > curPrice) {
                cont++;
            }

            return cont;
        }
    }
}