using Xunit;
using Day41;

namespace TestDay41;

public class UnitTestClothingStore
{
    [Fact]
    public void TestPairOfSocksStock()
    {
        int[] socks = new int[] {1,2,1,2,1,3,2};
        int expectedResult = 2;

        var actualResult = ClothingStores.PairOfSocksStock(socks);

        Assert.Equal(expectedResult, actualResult);
    }
}