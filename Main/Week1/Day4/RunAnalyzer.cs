using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public class RunAnalyzer
    {
        static void Main(string[] args) { }

        /// <summary>
        ///     Return the days with progression compared with the last run
        /// </summary>
        /// <param name="runs"> Runs in Miles to be analyzed</param>
        /// <returns> Number of progress days</returns>
        public static int ProgressDays(int[] runs) {
            int count = 0; // count the days of progression 
            for(int i = 1; i < runs.Length; i++)
            {
                if (runs[i] > runs[i - 1])
                    count++;
            }

            return count;
        }

    }
}
