using Day4;

namespace TestDay4
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(
            new int[] {},
            0
            )]
        [InlineData(
            new int[] { 2, 1 },
            0
            )]
        [InlineData(
            new int[] { 9, 9 },
            0
            )]
        [InlineData(
            new int[] { 3, 4, 1, 2 },
            2
            )]
        [InlineData(
            new int[] { 10, 11, 12, 9, 10 },
            3
            )]
        [InlineData(
            new int[] { 6, 5, 4, 3, 2, 9 },
            1
            )]
        public void TestProgression(int[] input, int expectedResult)
        {
            //act
            int actualResult = RunAnalyzer.ProgressDays(input);

            //assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}