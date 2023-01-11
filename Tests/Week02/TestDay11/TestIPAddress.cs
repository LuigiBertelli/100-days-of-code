using Xunit;
using Day11; 

namespace TestDay11
{
    public class UnitTest1
    {
        [Theory(DisplayName = "When input is a valid string return success")]
        [InlineData("", new string[]{})]
        [InlineData("00a00", new string[]{})]
        [InlineData("0000", new string[1]{"0.0.0.0"})]
        [InlineData("1111", new string[1]{"1.1.1.1"})]
        [InlineData("00100", new string[1]{"0.0.10.0"})]
        [InlineData("010010", new string[2]{"0.10.0.10","0.100.1.0"})]
        [InlineData("101023", new string[5]{"1.0.10.23","1.0.102.3","10.1.0.23","10.10.2.3","101.0.2.3"})]
        [InlineData("25525511135", new string[2]{"255.255.11.135","255.255.111.35"})]
        public void AllValidIPs(string inputData, string[] expectedResult)
        {
            var actualResult = IPAddress.AllValidIPs(inputData);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}