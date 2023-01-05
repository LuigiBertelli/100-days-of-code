using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class Searcher
    {
        static void Main(string[] args)
        {
        }

        public static string FindNemo(string toBeAnalyzed) {

            const string search = "Nemo";
            var words = toBeAnalyzed.Split(' ');
            int idxNemo = 0;

            for(int i = 1; i <= words.Length;i++) {
                if (words[i - 1].Equals(search)) {
                    idxNemo = i;
                    break;
                }
            }

            return idxNemo > 0 ? $"I found Nemo at {idxNemo}!" : "I can't find Nemo :(";
        }
    }
}
