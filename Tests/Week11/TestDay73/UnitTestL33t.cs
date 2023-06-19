using Xunit;
using Day73;

namespace TestDay73
{
    public class UnitTestL33t
    {
        [Theory]
        [InlineData("570R(V)", "storm")]
        public void TestTranslate(string input, string expectedResult)
        {
            var actualResult = L33t.Translate(input);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}