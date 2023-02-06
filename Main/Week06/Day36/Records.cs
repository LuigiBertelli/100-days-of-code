using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day36
{
    public class Records
    {
        protected List<int> _scores;
        
        public Records(int[] scores)
        {
            _scores = scores.ToList();
        }

        public int[] BreakingRecords()
        {
            var min = _scores.FirstOrDefault();
            var max = _scores.FirstOrDefault();
            var minBreaks = 0;
            var maxBreaks = 0;

            for(int i = 1; i < _scores.Count; i++) {
                if(_scores[i] > max) {
                    max = _scores[i];
                    maxBreaks++;
                }

                if(_scores[i] < min) {
                    min = _scores[i];
                    minBreaks++;
                }
            }

            return new int[2] {maxBreaks, minBreaks};
        }
    }
}