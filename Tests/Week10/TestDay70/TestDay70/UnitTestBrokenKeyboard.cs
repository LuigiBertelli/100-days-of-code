using Xunit;
using Day70;

namespace TestDay70
{
    public class UnitTestBrokenKeyboard
    {
        [Theory]
        [InlineData("abcd", "abaca")]
        [InlineData("edcf", "deeded")]
        [InlineData("bnik", "bikini")]
        [InlineData("poil", "lollipop")]
        [InlineData("vybu", "bubby")]
        [InlineData("subtoxymerhlac", "carboxymethylcelluloses")]
        public void TestLongestWord(string input, string expectedResult)
        {
            var keyboard = new BrokenKeyboard(input);
            var actualResult = keyboard.LongestWord();

            Assert.Equal(expectedResult, actualResult);
        }
    }
}