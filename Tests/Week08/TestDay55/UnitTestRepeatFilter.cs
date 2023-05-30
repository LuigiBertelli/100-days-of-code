using Xunit;
using Day55;

namespace TestDay55;

public class UnitTestRepeatFilter
{
    [Theory]
    [InlineData( new string[]{"aaaaaa", "bc", "d", "eeee", "xyz"}, new string[]{"aaaaaa", "d", "eeee"})]
    [InlineData( new string[]{"88", "999", "22", "545", "133"}, new string[]{"88", "999", "22"})]
    [InlineData( new string[]{"xxxxo", "oxo", "xox", "ooxxoo", "oxo"}, new string[]{})]
    public void TestIdenticalFilter(string[] input, string[] expectedResult)
    {
        var actualResult = RepeatFilter.IdenticalFilter(input);

        Assert.Equal(expectedResult, actualResult);
    }
}