using Xunit;
using Day35;

namespace TestDay35;

public class UnitTestGopher
{

    [Theory]
    [InlineData("day-35_sample_1_valid.txt", new string[]{ "The gopher cannot escape.", "The gopher can escape through the hole at (2.500000,2.500000)." })]
    [InlineData("day-35_sample_2_valid.txt", new string[]{ "The gopher cannot escape.", "The gopher can escape through the hole at (2.500000,2.500000)."})]
    public void TestgopherEscapePlan(string filename, string[] expectedResult)
    {
        var gopher = new Gopher(filename);

        var actualResult = gopher.gopherEscapePlan();

        Assert.Equal(expectedResult, actualResult);
    }

    [Theory]
    [InlineData("day-35_sample_3_invalid.txt")]
    [InlineData("day-35_sample_4_invalid.txt")]
    [InlineData("day-35_sample_5_invalid.txt")]
    public void TestgopherEscapePlanBadFile(string filename)
    {
        var gopher = new Gopher(filename);

        var actualResult = gopher.gopherEscapePlan();

        Assert.Equal(new string[]{"BAD FILE!"}, actualResult);
    }
}