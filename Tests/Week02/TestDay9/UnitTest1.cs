using Xunit;
using Day9;

namespace TestDay9{

    public class TestRain
    {
        [Theory]
        [InlineData(new int[12]{0,1,0,2,1,0,1,3,2,1,2,1}, 6)]
        [InlineData(new int[6]{4,2,0,3,2,5}, 9)]
        public void TestTrappingRainWater(int[] inputData, int expectedResult)
        {
            var actualResult = Rain.TrappingRainWater(inputData);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}