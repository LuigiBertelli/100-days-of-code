using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day28
{
    public class Words
    {
        public static IEnumerable<string> WordSearcher(char[,] board, string[] words)
        {
            bool isAdjacent((int x, int y) cell1, (int x, int y) cell2) => 
                (cell1.x == cell2.x && (cell1.y == (cell2.y - 1) || cell1.y == (cell2.y + 1))) 
                || (cell1.y == cell2.y && (cell1.x == (cell2.x - 1) || cell1.x == (cell2.x + 1)));

            bool isWordOnBoard(char nextLetter, (int x, int y) lastCell, Dictionary<char, List<(int, int)>> rest) {
                var next = rest.ElementAt(0);

                foreach(var pos in next.Value) {
                    if(lastCell.x == -1 && lastCell.y == -1 || isAdjacent(lastCell, pos)) {
                        if(rest.Count() == 1 || isWordOnBoard(next.Key, pos, rest.Where(x => x.Key != next.Key).ToDictionary(k => k.Key, v => v.Value)))
                            return true;
                    }
                }

                return false;
            }

            foreach(var word in words) {
                var wordCharList = word.ToCharArray().ToList();
                var dictAux = new Dictionary<char, List<(int, int)>>();
                foreach(var letter in word) {
                    List<(int, int)> lstAux = new List<(int, int)>();

                    for(int i = 0; i <= board.GetUpperBound(0); i++) {
                        for(int j = 0; j <= board.GetUpperBound(1); j++) {
                            if(board[i,j] == letter)
                                lstAux.Add((i, j));
                        }
                    }

                    dictAux.Add(letter, lstAux);
                }
                

                if(isWordOnBoard(word[0], (-1, -1), dictAux))
                    yield return word;
            }
        }
    }
}