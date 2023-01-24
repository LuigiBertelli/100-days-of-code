using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day23.Models;

namespace Day23.Controllers
{
    public class PhilosophersTable
    {
        private const int PHILOSOPHERS_COUNT = 5;
        protected List<Philosopher> _philosophers;

        public List<int[]> philosopherOpList = new List<int[]>();

        public class ThreadWithState
        {
            private Philosopher _philosopher;
            public List<int[]> _philosopherOpList;

            static readonly object Identity = new object ();

            public ThreadWithState(Philosopher philosopher, List<int[]> philosopherOpList)
            {
                _philosopher = philosopher;
                _philosopherOpList = philosopherOpList;
            }

            public void WantsToEat() 
            {    
                    while (_philosopher._remainingServes > 0) {   
                       lock(Identity){
                            _philosopherOpList.AddRange(_philosopher.PickForksUp());   
                        }     
                        _philosopherOpList.Add(_philosopher.Eat());        
                        _philosopherOpList.AddRange(_philosopher.PutForksDown());
                    }
                
            }
        }

        public PhilosophersTable(int n)
        {
             _philosophers = new List<Philosopher>();

            _philosophers.Add(new Philosopher(n));

            for(int i = 1; i < PHILOSOPHERS_COUNT; i++) {
                Philosopher newPhilosopher = new Philosopher(n);
                newPhilosopher._leftPhilosopher = _philosophers[i - 1];

                _philosophers.Add(newPhilosopher);
            }

            _philosophers[0]._leftPhilosopher = _philosophers[PHILOSOPHERS_COUNT - 1];

            for(int j = 0; j < PHILOSOPHERS_COUNT - 1; j++) {
                _philosophers[j]._rightPhilosopher = _philosophers[j + 1];
            }

            _philosophers[PHILOSOPHERS_COUNT - 1]._rightPhilosopher = _philosophers[0];
        }   

        public int[][] Dining()
        {
            philosopherOpList = new List<int[]>();
            Thread[] trdList = new Thread[PHILOSOPHERS_COUNT];
            for(int i = 0; i < PHILOSOPHERS_COUNT; i++) {
                ThreadWithState tws = new ThreadWithState(_philosophers[i], philosopherOpList);
                trdList[i] = new Thread(() => tws.WantsToEat());
                trdList[i].IsBackground = true;
                trdList[i].Start();
            }

            foreach(var it in trdList)
                it.Join();
            return philosopherOpList.ToArray();
        }
    }
}