using Xunit;
using Day68;

namespace TestDay68
{
    public class UnitTestSlowTypist
    {
        [Theory]
        [InlineData("219.45.143.143)", "27.378 cm")]
        [InlineData("(7851)", "3.414 cm")]
        [InlineData("(1111)", "0.000 cm")]
        [InlineData("(123654789)", "8.000 cm")]
        [InlineData("-(123654-789", "8.000 cm")]
        public void TestType(string input, string expectedResult)
        {
            var actualResult = SlowTypist.Type(input);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}