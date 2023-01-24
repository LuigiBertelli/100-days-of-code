using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day24
{
    public class Josephus
    {
        SoldierChain first = new SoldierChain(1);

        public Josephus(int n)
        {
            SoldierChain soldier = first;
            
            for(int i = 2; i <= n; i++) {
                SoldierChain newSoldier = new SoldierChain(i);
                newSoldier.Before = soldier;
                soldier.Next = newSoldier;

                soldier = newSoldier;
            }

            soldier.Next = first;
            first.Before = soldier;
        }

        public int WillRemain(int interval) 
        {
            SoldierChain soldier = first;


            while(soldier.Next != null) {
                 for(int i = 0; i < interval - 1; i++) {
                     soldier = soldier.Next;
                 }

                 soldier.Kill();
                 soldier = soldier.Next;
            }

            return soldier.pos;
        }
    }
}