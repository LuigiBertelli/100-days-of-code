using Xunit;
using Day17;

namespace TestDay17
{    
    public class TestPrisonBreak
    {
        [Theory(DisplayName = "When inputData is a valid array of int test returns success")]
        [InlineData(new int[]{1, 1, 0, 0, 0, 1, 0}, 4)]
        [InlineData(new int[]{1, 1, 1}, 1)]
        [InlineData(new int[]{0, 0, 0}, 0)]
        [InlineData(new int[]{0, 1, 1, 1}, 0)]
        [InlineData(new int[]{1, 0}, 2)]
        public void Test1(int[] cells, int expectedFreedPrisoners)
        {
            var actualFreedPrisoners = new PrisonBreak(cells).FreedPrisoners();

            Assert.Equal(expectedFreedPrisoners, actualFreedPrisoners);
        }
    }
}