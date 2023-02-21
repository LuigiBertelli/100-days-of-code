using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day51
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
        }
    }

    public class Asteroids
    {
        private int[] _asteroids = new int[]{};
        public Asteroids(int[] asteroids)
        {
            _asteroids = asteroids;
        }

        public int[] Crash()
        {
            var removedPos = new List<int>();
            var asteroidsLst = _asteroids.ToList();

            for(int i = 1; i < _asteroids.Length; i++) {
                var cur = _asteroids[i];

                if(i > 0 && cur < 0) {
                    var ant = i - 1;
                    while(ant >= 0 && _asteroids[ant] > 0) {
                        if(Math.Abs(cur) > _asteroids[ant]) {
                            removedPos.Add(ant);
                        } else {
                            if(Math.Abs(cur) == _asteroids[ant]) {
                                removedPos.Add(ant);
                            }
                            removedPos.Add(i);
                            break;
                        }

                        ant--;
                    }
                }
            } 

            for(int j = 0; j < _asteroids.Length; j++) {
                if(removedPos.Contains(j)) {
                    asteroidsLst[j] = 0;
                }
            }

            return asteroidsLst.Where(x => x != 0).ToArray();
        }
    }
}