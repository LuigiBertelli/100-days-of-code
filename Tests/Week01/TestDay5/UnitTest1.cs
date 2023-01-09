using Xunit;
using Day5;

namespace TestDay5{

    public class UnitTest1
    {
        [Theory(DisplayName = "When SockPairs receive a a valid string it returns success")]
        [InlineData("", 0)]
        [InlineData("AB", 0)]
        [InlineData("AA", 1)]
        [InlineData("ABAA", 1)]
        [InlineData("ABABC", 2)]
        [InlineData("CABBACCC", 4)]
        public void SockPairsMethodTest(string inputData, int expectedResult)
        {
            var actualResult = Sock.SockPairs(inputData);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}