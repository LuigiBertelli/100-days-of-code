using Xunit;
using Day44;

namespace TestDay44;

public class UnitTest1
{
    [Theory]
    [InlineData(8, 10, 17)]
    [InlineData(5, 7, 11)]
    [InlineData(9, 2, 10)]
    public void TestMaximumEdge(int firstSide, int secondSide, int expectedResult)
    {
        var actualResult = Triangle.MaximumEdge(firstSide, secondSide);

        Assert.Equal(expectedResult, actualResult); 
    }
}