using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day46
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
        }
    }

    public class Watcher
    {
        private static string[] DISTRACTIONS = new string[] {"anime",
            "meme",
            "vines",
            "roasts",
            "danny devito"};

        public static string PreventDistractions(string phrase)
        {
            foreach(var dist in DISTRACTIONS) {
                if(phrase.ToLower().Contains(dist)) {
                    return "NO!";
                }
            }

            return "Safe watching!";
        }
    }
}