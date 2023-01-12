using Xunit;
using Day12;

namespace TestDay12
{
    public class TestLandscape
    {
        [Theory(DisplayName = "When input is a valid array of integers and output is \"mountain\" result is success")]
        [InlineData(new int[]{1, 3, 5, 4, 3, 2})]
        [InlineData(new int[]{-1, 0, -1})]
        [InlineData(new int[]{-1, -1, 0, -1, -1})]
        [InlineData(new int[]{3, 4, 5, 4, 3})]
        public void TestLandscapeWhenOutputIsMountaind(int[] inputData)
        {
            var actualResult = Landscape.LandscapeType(inputData);
            
            Assert.Equal("mountain", actualResult);
        }

        [Theory(DisplayName = "When input is a valid array of integers and output is \"valley\" result is success")]
        [InlineData(new int[]{10, 9, 8, 7, 2, 3, 4, 5})]
        [InlineData(new int[]{350, 100, 200, 400, 700})]
        [InlineData(new int[]{9, 7, 3, 1, 2, 4})]
        [InlineData(new int[]{9, 8, 9})]
        public void TestLandscapeTypeWhenOutputIsValley(int[] inputData)
        {
            var actualResult = Landscape.LandscapeType(inputData);

            Assert.Equal("valley", actualResult);
        }


        [Theory(DisplayName = "When input is a valid array of integers and output is \"neither\" result is success")]
        [InlineData(new int[]{})]
        [InlineData(new int[]{1, 2, 3, 2, 4, 1})]
        [InlineData(new int[]{5, 4, 3, 2, 1})]
        [InlineData(new int[]{0, -1, -1, 0, -1, -1})]
        [InlineData(new int[]{9, 8, 9, 8})]
        public void TestLandscapeTypeWhenOutputIsNeither(int[] inputData)
        {
            var actualResult = Landscape.LandscapeType(inputData);

            Assert.Equal("neither", actualResult);
        }
    }
}