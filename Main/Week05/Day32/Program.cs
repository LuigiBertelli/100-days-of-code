using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day32
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var rankedScores = new int[] { 100, 90, 90, 80 };

            var player = new Leaderboard(rankedScores);

            var playerScores = new int[] { 70, 80, 105 };

            var result = player.PlayerRank(playerScores);

            foreach(var it in result) {
                Console.WriteLine(it);
            }
        }
    }
}