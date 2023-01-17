using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day17
{
    public class PrisonBreak
    {
        public int[] _cells;

        public PrisonBreak(int[] cells)
        {
            _cells = cells;
        }

        public int FreedPrisoners()
        {
            int freedPrisoners = 0;
            List<int> auxList = _cells.ToList();
            int next = auxList[0] == 1? 0 : -1;

            while(next >= 0 && next <= auxList.Count() - 1)
            {
                freedPrisoners++;
                auxList = auxList.Select(x => x == 1? 0: 1).ToList();
                next = auxList.IndexOf(1, next + 1);
            }

            return freedPrisoners;
        }
    }
}