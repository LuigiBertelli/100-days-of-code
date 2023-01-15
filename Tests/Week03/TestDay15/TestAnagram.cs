using Xunit;
using Day15;

namespace TestDay15
{
    public class TestAnagram
    {
        [Theory( DisplayName = "")]
        [InlineData("more", "remo")]
        [InlineData("anagram", "nagaram")]
        [InlineData("radio", "diora")]
        public void TestIsAnagramTrue(string baseStr, string possibleAnagram)
        {
            var actualResult = Anagram.IsAnagram(baseStr, possibleAnagram);

            Assert.True(actualResult);
        }

        [Theory( DisplayName = "")]
        [InlineData("rat", "car")]
        [InlineData("otimas", "mistaoda")]
        [InlineData("cel", "ceu")]
        public void TestIsAnagramFalse(string baseStr, string possibleAnagram)
        {
            var actualResult = Anagram.IsAnagram(baseStr, possibleAnagram);

            Assert.False(actualResult);
        }
    }
}