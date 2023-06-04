using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day60
{
    public class GameOfThrees
    {
        public int startNumber { get; private set; }
        public GameOfThrees(int num) 
        {
            try {
                if(num < 1) throw new ArgumentOutOfRangeException(nameof(num));
                startNumber = num;
            } catch(Exception ex) { 
                Console.WriteLine(ex.Message);
            }
            
        }

        public IEnumerable<int> Play()
        {
            var num = startNumber;

            while (num != 1)
            {
                if (num % 3 == 0) { 
                    yield return 0;
                    num /= 3;
                } else if((num - 1) % 3 == 0) {
                    yield return -1;
                    num = (num - 1) / 3;
                } else {
                    yield return 1;
                    num = (num + 1) / 3;
                }
                    
            }
        }
    }
}
