using Xunit;
using Day53;

namespace TestDay53;

public class UnitTestParable
{
    [Theory]
    [InlineData(36.7, 45, "Ymax=34m, Xmax=137m")]
    [InlineData(51.3, 20, "Ymax=16m, Xmax=172m")]
    [InlineData(100.1, 89, "Ymax=511m, Xmax=36m")]
    public void TestJavelinThrow(double vel, double angle, string expectedResult)
    {
        var actualResult = Parable.JavelinThrow(vel, angle);

        Assert.Equal(expectedResult, actualResult);
    }
}