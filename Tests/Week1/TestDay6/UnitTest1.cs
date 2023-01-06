using Xunit;
using Day6;

namespace TestDay6 {


    public class TestPrimeNumbers
    {
        [Theory(DisplayName = "When input is a valid integer, return success. (using positive number)")]
        [InlineData(1, 2)]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        [InlineData(4, 5)]
        [InlineData(11, 11)]
        [InlineData(12, 13)]
        [InlineData(24, 29)]
        public void TestNextPrimeNumberUsingPositiveInt(int inputData, int expectedResult)
        {
            var actualResult = PrimeNumbers.NextPrime(inputData);

            Assert.Equal(expectedResult, actualResult);
        }

        [Theory(DisplayName = "When input is a valid integer, return success. (using negative number and 0)")]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-2)]
        [InlineData(-3)]
        public void TestNextPrimeNumberUsingNegativeIntAndZero(int inputData)
        {
            var actualResult = PrimeNumbers.NextPrime(inputData);

            Assert.Equal(2, actualResult);
        }
    } 
}