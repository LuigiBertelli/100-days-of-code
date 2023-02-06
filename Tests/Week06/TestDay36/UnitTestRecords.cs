using Xunit;
using Day36;

namespace TestDay36;

public class UnitTestRecords
{
    [Theory]
    [InlineData(new int[]{10,5,20,20,4,5,2,25,1}, new int[2]{2,4})]
    [InlineData(new int[]{12,24,10,24}, new int[2]{1,1})]
    [InlineData(new int[]{}, new int[2]{0,0})]
    public void TestBreakingRecords(int[] scores, int[] expectedResults)
    {
        var record = new Records(scores);

        var actualResults = record.BreakingRecords();

        Assert.Equal(expectedResults, actualResults);
    }
}