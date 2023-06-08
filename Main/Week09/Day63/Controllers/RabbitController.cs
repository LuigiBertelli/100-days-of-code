using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day63.Controllers
{
    public class RabbitController
    {
        public static int RabbitDomination(int male, int female, long bound)
        {
            const int MALES_PER_BREED = 5;
            const int FEMALES_PER_BREED = 9;
            const int STARTERS_AGE = 2;
            const int ALIVE_AGE_LIMIT = 95;
            const int WOMAN_FERTILE_STAGE = 4;

            if (female < 0 || male < 0 || ((male + female) < bound && female == 0))
            {
                throw new ArgumentException();
            }

            var deadRabbits = 0L;
            var months = 0;

            var maleRabbitsAge = new long[ALIVE_AGE_LIMIT + 1];
            var femaleRabbitsAge = new long[ALIVE_AGE_LIMIT + 1];

            maleRabbitsAge[STARTERS_AGE] = male;
            femaleRabbitsAge[STARTERS_AGE] = female;

            while (true)
            {
                var femalesFertile = femaleRabbitsAge.Skip(WOMAN_FERTILE_STAGE + 1).Sum();
                femaleRabbitsAge[0] = femalesFertile * FEMALES_PER_BREED;
                maleRabbitsAge[0] = femalesFertile * MALES_PER_BREED;

                if (bound <= maleRabbitsAge.Sum() + femaleRabbitsAge.Sum())
                    break;

                for (int i = ALIVE_AGE_LIMIT; i >= 0; i--)
                {
                    if (i == ALIVE_AGE_LIMIT)
                        deadRabbits = maleRabbitsAge[i] + femaleRabbitsAge[i];
                    else
                    {
                        maleRabbitsAge[i + 1] = maleRabbitsAge[i];
                        femaleRabbitsAge[i + 1] = femaleRabbitsAge[i];
                    }

                    maleRabbitsAge[i] = 0;
                    femaleRabbitsAge[i] = 0;
                }

                months++;
            }

            Console.WriteLine($"RIP all the {deadRabbits} Rabbits that died in this journey");

            return months;
        }
    }
}
