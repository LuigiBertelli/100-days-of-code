using Xunit;
using Day62;

namespace TestProject1
{
    public class UnitTestFunnyPlant
    {
        [Theory]
        [InlineData(200, 15, 5)]
        [InlineData(50000, 1, 14)]
        [InlineData(150000, 250, 9)]
        [InlineData(21, 1, 5)]
        public void TestWeeks(int people, int start, int expectedResult)
        {
            var actualResul = FunnyPlant.Weeks(people, start);

            Assert.Equal(expectedResult, actualResul);
        }
    }
}