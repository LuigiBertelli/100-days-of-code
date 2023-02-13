using Xunit;
using Day39;

namespace TestDay39;

public class UnitTestMist
{
    [Fact]
    public void TestHowManyGames()
    {
        const double normalPrice = 20;
        const double discount = 3;
        const double minPrice = 6;
        const double budget = 80;
        const double expectedResult = 6;

        var actualResult = Mist.HowManyGames(normalPrice, discount, minPrice, budget);

        Assert.Equal(expectedResult, actualResult);
    }
}