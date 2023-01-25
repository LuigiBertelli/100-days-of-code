using Xunit;
using Day25;

namespace TestDay25;

public class UnitTest1
{
    [Theory]
    [InlineData(new int[]{})]
    [InlineData(new int[]{1, 2, 3, 2, 2, 2, 3})]
    [InlineData(new int[]{2, 4, 3, 2, 4, 9, 7, 8, 6, 9})]
    public void TestCoinDivTrue(int[] coinsArray)
    {
        var actualResult = CoinTrouble.CoinDiv(coinsArray);

        Assert.True(actualResult);
    }

    [Theory]
    [InlineData(new int[]{5, 3, 10, 1, 2})]
    [InlineData(new int[]{4, 4, 4, 4})]
    [InlineData(new int[]{23, 3, 4})]
    public void TestCoinDivFalse(int[] coinsArray)
    {
        var actualResult = CoinTrouble.CoinDiv(coinsArray);

        Assert.False(actualResult);
    }
}