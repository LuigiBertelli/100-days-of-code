using Xunit;
using Day30;

namespace TestDay30;

public class TestAlgorism
{
    [Theory]
    [InlineData(276, 3, 3276)]
    [InlineData(860, 7, 8760)]
    [InlineData(-999, 4, -4999)]
    [InlineData(0, 3, 30)]
    public void TestMaximum(int num, int digit, int expectedResult)
    {
        var actualResult = Algorism.Maximum(num, digit);

        Assert.Equal(expectedResult, actualResult);
    }
}