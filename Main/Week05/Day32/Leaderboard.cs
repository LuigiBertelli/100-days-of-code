using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day32
{
    public class Leaderboard
    {
        public Dictionary<int, int> _leaderBoard = new Dictionary<int, int>();

        public Leaderboard(int[] rankedScores)
        {
            foreach(var score in rankedScores) {
                if(_leaderBoard.Count == 0)
                    _leaderBoard.Add(1, score);
                else {
                    bool doubled = false;
                    int i = _leaderBoard.Count;

                    while(i >= 1 && _leaderBoard[i] <= score && !doubled) {
                        if(_leaderBoard[i] < score){
                            _leaderBoard.Add(i + 1, _leaderBoard[i]);
                            _leaderBoard.Remove(i);
                        } else if(_leaderBoard[i] == score) {
                            doubled = true;
                        }

                        i--;
                    }
                    
                    if(!doubled)
                        _leaderBoard.Add(i + 1, score);
                
                    
                }
            }
        }

        public int[] PlayerRank(int[] playerScores)
        {
            
            var ranks = new int[playerScores.Length];

            for(int i = 0; i < playerScores.Length; i++) {
                var score = playerScores[i];

                int j = _leaderBoard.Count;

                while(j >= 1 && _leaderBoard[j] <= score) { 
                    j--;
                }

                ranks[i] = j + 1;
            }

            return ranks;
        }
    }
}