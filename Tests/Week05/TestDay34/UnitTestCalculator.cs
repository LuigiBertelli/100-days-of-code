using Xunit;
using Day34;

namespace TestDay34;

public class UnitTestCalculator
{
    [Theory]
    [InlineData(123, 456, 0)]
    [InlineData(1, 2, 0)]
    [InlineData(1, 20000, 0)]
    [InlineData(123, 549, 1)]
    [InlineData(555, 555, 3)]
    [InlineData(555, 545, 3)]
    public void TestCarryOnSum(int n1, int n2, int expectedResult)
    {
        var actualResult = Calculator.CarryOnSum(n1, n2);

        Assert.Equal(expectedResult, actualResult);
    }
}