using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day50
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
        }
    }

    public class TicTacToe
    {
        public static string Winner(string[,] board)
        {
            var winner = string.Empty;

            for(int i = 0; i < 3; i++) {
                if(board[i, 0] != "#" && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    if(board[i, 0] == "O") {
                        return "Player 1 wins";
                    } else {
                        return "Player 2 wins";
                    }
                }
            }

            for(int j = 0; j < 3; j++) {
                if(board[0, j] != "#" && board[0, j] == board[1, j] && board[1, j] == board[2, j])
                {
                    if(board[0, j] == "O") {
                        return "Player 1 wins";
                    } else {
                        return "Player 2 wins";
                    }
                }
            }

            return "It's a Tie";
        }
    }
}