using Xunit;
using Day60;

namespace TestDay60
{
    public class UnitTestGameOfThrees
    {
        [Fact]
        public void TestPlay()
        {
            const int startNum = 100;
            IEnumerable<int> expectedResult = new[] { -1, 0, 1, -1 };

            var game = new GameOfThrees(startNum);

            var actualResult = game.Play();

            Assert.Equal(expectedResult, actualResult);
        }
    }
}