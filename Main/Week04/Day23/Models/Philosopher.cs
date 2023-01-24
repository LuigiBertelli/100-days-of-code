using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Day23.Enums;

namespace Day23.Models
{
    public class Philosopher
    {
        private static int CONT = 0;
        public int _id { get; protected set; }
        public PhilosopherStates _state;
        public int _remainingServes;
        public Philosopher? _leftPhilosopher = null;
        public Philosopher? _rightPhilosopher = null;
        public bool _rightFork = false;
        public bool _leftFork = false;

        
        static readonly object Identity = new object ();

        public Philosopher(int n = 1)
        {
            _id = CONT;
            _state = PhilosopherStates.Thinking;
            _remainingServes = n;
            CONT++;
        }

        public int[][] PickForksUp()
        {
            while(_leftPhilosopher._state == PhilosopherStates.Eating || _rightPhilosopher._state == PhilosopherStates.Eating) {
                Thread.Sleep(100);
            }

            _leftFork = true;
            _rightFork = true;

            _state = PhilosopherStates.Eating;

            return new int[][] {new int[]{_id, (int) Hands.Left, (int) PhilosopherOperations.Pick}, new int[]{_id, (int) Hands.Right, (int) PhilosopherOperations.Pick}};
        
        }

        public int[] Eat(){
            _remainingServes--;

            return new int[]{ _id, (int) Hands.Both, (int) PhilosopherOperations.Eat };
        }

        public int[][] PutForksDown()
        {
            _leftFork = false;
            _rightFork = false;
            _state = PhilosopherStates.Thinking;
            return new int[][] {new int[]{_id, (int) Hands.Left, (int) PhilosopherOperations.Put}, new int[]{_id, (int) Hands.Right, (int) PhilosopherOperations.Put}};
        
        }
    }
}