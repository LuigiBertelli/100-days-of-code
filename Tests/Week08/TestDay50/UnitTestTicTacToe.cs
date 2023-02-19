using Xunit;
using Day50;

namespace TestDay50;

public class UnitTestTicTacToe
{
    [Fact]
    public void TestWinnerPlayer1()
    {
        string[,] board = new string[,] {
            {"O", "O", "O"},
            {"O", "X", "O"},
            {"X", "#", "X"}
        };

        var result = TicTacToe.Winner(board);

        Assert.Equal("Player 1 wins", result);
    }

    [Fact]
    public void TestWinnerPlayer2()
    {
        string[,] board = new string[,] {
            {"X", "X", "X"},
            {"X", "O", "X"},
            {"O", "#", "O"}
        };

        var result = TicTacToe.Winner(board);

        Assert.Equal("Player 2 wins", result);
    }

    [Fact]
    public void TestWinnerTie()
    {
        string[,] board = new string[,] {
            {"X", "X", "O"},
            {"O", "X", "O"},
            {"X", "O", "#"}
        };

        var result = TicTacToe.Winner(board);

        Assert.Equal("It's a Tie", result);
    }
}