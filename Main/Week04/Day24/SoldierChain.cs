using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day24
{
    public class SoldierChain
    {
        public int pos;

        public SoldierChain? Before = null;
        public SoldierChain? Next = null;

        public SoldierChain(int pos)
        {
            this.pos = pos;
        }

        public void Kill() 
        {
            if(Before != null && Next != Before) {
                if(Before != null)
                    Before.Next = Next;
                
                if(Next != null)
                    Next.Before = Before;  
            } else {
                Before.Next = null;
                Next.Before = null;
            }
                 
        }
    }
}