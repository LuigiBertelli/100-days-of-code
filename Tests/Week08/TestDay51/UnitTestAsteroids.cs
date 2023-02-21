using Xunit;
using Day51;

namespace TestDay51;

public class UnitTestAsteroids
{
    [Theory]
    [InlineData(new int[]{5, 10, -5}, new int[]{5, 10})]
    [InlineData(new int[]{8, -8}, new int[]{})]
    [InlineData(new int[]{10,2,-5}, new int[]{10})]
    [InlineData(new int[]{-2,-1,1,2}, new int[]{-2,-1,1,2})]
    public void TestCrash(int[] asteroid, int[] expectedResult)
    {   
        var asteroidsObj = new Asteroids(asteroid);
        var actualResult = asteroidsObj.Crash();

        Assert.Equal(expectedResult, actualResult);
    }
}