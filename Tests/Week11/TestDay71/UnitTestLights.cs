using Xunit;
using Day71;

namespace TestDay71
{
    public class UnitTestLights
    {
        [Fact]
        public void TestTimesOn1()
        {
            var input = new int[][] { new int[] { 2, 4 }, new int[] { 3, 6 }, new int[] { 1, 3 }, new int[] { 6, 8 } };
            int expectedResult = 7;

            var actualResult = Lights.TimesOn(input);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TestTimesOn2()
        {
            var input = new int[][] { new int[] { 6, 8 }, new int[] { 5, 8 }, new int[] { 8, 9 }, new int[] { 5, 7 }, new int[] { 4, 7 } };
            int expectedResult = 5;

            var actualResult = Lights.TimesOn(input);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}