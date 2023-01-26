using Xunit;
using Day26;

namespace TestDay26;

public class TestBriefCaseLock
{
    [Theory(DisplayName = "When both input data(n1 and n2) are valid numerical positive strings, test return success")]
    [InlineData("4089", "5672", 9)]
    [InlineData("1111", "1100", 2)]
    [InlineData("2391", "4984", 10)]
    public void TestMinTurns(string n1, string n2, int expectedResult)
    {
        var actualResult = BriefCaseLock.MinTurns(n1, n2);

        Assert.Equal(expectedResult, actualResult);
    }
}