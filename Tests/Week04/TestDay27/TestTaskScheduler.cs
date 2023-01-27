using Xunit;
using Day27;

namespace TestDay27;

public class TestTaskScheduler
{
    [Theory]
    [InlineData(new string[]{"A","A","A","B","B","B"}, 0, 6)]
    [InlineData(new string[]{"A","A","A","B","B","B"}, 2, 8)]
    [InlineData(new string[]{"A","A","A","A","A","A","B","C","D","E","F","G"}, 2, 16)]
    public void TestTasksTime(string[] tasks, int interval, int expectedResult)
    {
        var actualResult = new Day27.TaskScheduler(tasks, interval).TasksTime();

        Assert.Equal(expectedResult, actualResult);
    }
}