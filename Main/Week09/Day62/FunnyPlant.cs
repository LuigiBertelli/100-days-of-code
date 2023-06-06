using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day62
{
    public class FunnyPlant
    {
        public static int Weeks(int people, int start)
        {
            int weeks = 1;
            var fruits = new List<int>(new int[start]);
            while(fruits.Sum() < people)
            {
                var max = fruits.Count();
                for (int i = 0; i < max; i++)
                {
                    fruits[i]++;
                    fruits.AddRange(new int[fruits[i]]);
                }
                weeks++;
            }
            return weeks;
        }
    }
}
