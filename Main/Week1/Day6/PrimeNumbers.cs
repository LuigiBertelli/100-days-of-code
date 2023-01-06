using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day6
{
    public class PrimeNumbers
    {
        public static int NextPrime(int baseNumber) 
        {
            if(baseNumber <= 2 )
                return 2;
            else {
                bool isPrime = false;
                int auxNumber = baseNumber;
                int i;

                while(!isPrime)
                {
                    int max = (int) Math.Ceiling(auxNumber / 2.0d);

                    for(i = 2; i <= max; i++) {
                        if(auxNumber % i == 0) 
                            break;
                    }

                    if(i == max + 1)
                        isPrime = true;
                    else
                        auxNumber++;
                }

                return auxNumber;
            }
        }
    }
}