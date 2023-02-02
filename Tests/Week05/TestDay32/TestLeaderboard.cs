using Xunit;
using Day32;

namespace TestDay32;

public class TestLeaderboard
{
    [Theory]
    [InlineData(
        new int[] { 100, 90, 90, 80 },
        new int[] { 70, 80, 105 },
        new int[] { 4, 3, 1 }
    )]
    [InlineData(
        new int[] { 100, 90, 90, 80 },
        new int[] { 106, 107, 105 },
        new int[] { 1, 1, 1}
    )]
    public void TestPlayerRank(int[] rankedScores, int[] playerScores, int[] expectedResults)
    {
        var leaderboard = new Leaderboard(rankedScores);

        var actualResults = leaderboard.PlayerRank(playerScores);

        Assert.Equal(expectedResults, actualResults);
    }
}