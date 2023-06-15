using Xunit;
using Day72;

namespace TestDay72
{
    public class UnitTestL33t
    {
        [Theory]
        [InlineData("storm", "570R(V)")]
        public void TestConvert(string input, string expectedResult)
        {
            var actualResult = L33t.Convert(input);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}