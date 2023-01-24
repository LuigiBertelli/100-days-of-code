using Xunit;
using Day24;

namespace TestDay24;

public class TestJosephus
{
    [Theory]
    [InlineData(41, 3, 31)]
    [InlineData(35, 11, 18)]
    [InlineData(2, 2, 1)]
    [InlineData(11, 1, 11)]
    public void TestWillRemain(int soldiersCount, int interval, int expectedResult)
    {
        var actualResult = new Josephus(soldiersCount).WillRemain(interval);

        Assert.Equal(expectedResult, actualResult);
    }
}