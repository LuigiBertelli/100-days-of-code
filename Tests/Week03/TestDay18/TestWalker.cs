using Xunit;
using Day18;

namespace TestDay18
{
    public class TestWalker
    {
        [Theory(DisplayName = "When m and n are valid int then result is success")]
        [InlineData(7, 3, 28)]
        [InlineData(3, 2, 3)]
        [InlineData(3, 3, 6)]
        public void TestUniquePaths(int m, int n, int expecteResult)
        {
            var newWalker = new Walker(m, n);
            var actualResult = newWalker.UniquePaths();

            Assert.Equal(expecteResult, actualResult);
        }
    }
}