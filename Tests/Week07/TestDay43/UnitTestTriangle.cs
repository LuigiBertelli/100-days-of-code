using Xunit;
using Day43;

namespace TestDay43;

public class UnitTestTriangle
{
    [Theory]
    [InlineData(2d, 2d, 2d)]
    [InlineData(3d, 2d, 3d)]
    [InlineData(5d, 4d, 10d)]
    [InlineData(7d, 4d, 14d)]
    [InlineData(10d, 10d, 50d)]
    [InlineData(12d, 11d, 66d)]
    [InlineData(0d, 60d, 0d)]
    public void Test1(double triBase, double triHeight, double expectedResult)
    {
        var tri1 = new Triangle(triBase, triHeight);

        Assert.Equal(expectedResult, tri1.Area);
    }
}