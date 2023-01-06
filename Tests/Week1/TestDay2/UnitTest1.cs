using Day2;
using System.ComponentModel;

namespace TestDay2
{
    public class UnitTest1
    {
        [Theory(DisplayName = "Result is success when input string is well")]
        [InlineData("", "I can't find Nemo :(")]
        [InlineData("I am nemor", "I can't find Nemo :(")]
        [InlineData("nemo", "I can't find Nemo :(")]
        [InlineData("Nemo", "I found Nemo at 1!")]
        [InlineData("I am Nemo", "I found Nemo at 3!")]
        [InlineData("I am nemo", "I can't find Nemo :(")]
        public void Test1(string input, string expectedResult)
        {
            //act
            string actualResult = Searcher.FindNemo(input);

            //assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}