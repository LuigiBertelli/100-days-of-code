using Xunit;
using Day16;

namespace TestDay16{

    public class UnitTest1
    {
        [Theory(DisplayName = "Testing method CanWin, when inputData is a valid int and method returns true, successful test")]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        public void TestCanWinTrue(int inputData)
        {
            var actualResult = NimGame.CanWin(inputData);
            
            Assert.True(actualResult);
        }

        [Theory(DisplayName = "Testing method CanWin, when inputData is a valid int and method returns false, successful test")]
        [InlineData(4)]
        [InlineData(8)]
        [InlineData(12)]
        [InlineData(16)]
        [InlineData(20)]
        [InlineData(24)]
        public void TestCanWinFalse(int inputData)
        {
            var actualResult = NimGame.CanWin(inputData);
            
            Assert.False(actualResult);
        }
    }
}