using Xunit;
using Day37;

namespace TestDay37;

public class UnitTestEletronicShop
{
    [Theory]
    [InlineData(new double[] {40,50,60}, new double[] {5,8,12}, 60, 58)]
    public void TestGetMoneySpent(double[] keyboards, double[] drivers, double budget, double expectedResult)
    {
        var actualResult = EletronicShop.GetMoneySpent(keyboards, drivers, budget);

        Assert.Equal(expectedResult, actualResult);
    }
}