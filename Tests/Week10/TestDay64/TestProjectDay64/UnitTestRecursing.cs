using Xunit;
using Day64;

namespace TestProjectDay64
{
    public class UnitTestRecursing
    {
        [Theory]
        [InlineData("BBAS", 'B')]
        [InlineData("KNFDKLSANLKFNAK", 'K')]
        public void TestFirst(string input, char expectedResult)
        {
            var actualResult = Recursing.First(input);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}