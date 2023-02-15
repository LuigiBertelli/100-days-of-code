using Xunit;
using Day46;

namespace TestDay46;

public class UnitTestWatcher
{
    [Theory]
    [InlineData("vines that butter my eggroll")]
    [InlineData("Hot pictures of Danny DeVito")]
    [InlineData("anime")]
    [InlineData("meme")]
    [InlineData("roasts")]
    public void TestPreventDistractionsNo(string phrase)
    {
        const string expectedResult = "NO!";

        var actualResult = Watcher.PreventDistractions(phrase);

        Assert.Equal(expectedResult, actualResult);
    }

    [Theory]
    [InlineData("manie")]
    [InlineData("How to ace BC Calculus in 5 Easy Steps")]
    [InlineData("")]
    public void TestPreventDistractionsSafe(string phrase)
    {
        const string expectedResult = "Safe watching!";

        var actualResult = Watcher.PreventDistractions(phrase);

        Assert.Equal(expectedResult, actualResult);
    }
}