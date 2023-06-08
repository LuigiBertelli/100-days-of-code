using Xunit;
using Day63.Controllers;

namespace TestProjectDay63
{
    public class UnitTestRabbits
    {
        [Theory]
        [InlineData(2, 4, 1000000000, 32)]
        [InlineData(2, 4, 15000000000, 36)]
        public void TestRabbitDomination(int males, int females, long bound, int expectedResult)
        {
            var actualResult = RabbitController.RabbitDomination(males, females, bound);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}