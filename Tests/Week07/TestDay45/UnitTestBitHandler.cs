using Xunit;
using Day45;


namespace TestDay45;

public class UnitTestBitHandler
{
    [Theory]
    [InlineData(10, 41, 31)]
    [InlineData(69, 420, 351)]
    [InlineData(12345, 890412, 878067)]
    [InlineData(2, 1, -1)]
    public void TestXOR(int n1, int n2, int expectedResult)
    {
        var actualResult = BitHandler.XOR(n1, n2);

        Assert.Equal(expectedResult, actualResult);
    }
}