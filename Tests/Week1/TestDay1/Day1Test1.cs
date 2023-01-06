using Microsoft.VisualStudio.TestPlatform.TestHost;
using Day1;

namespace TestDay1
{
    public class Day1Test1
    {
        [Fact(DisplayName = "Given valid numbers, when converting age to days then should succcess.")]
        public void Test1()
        {
            //arrange
            const int age = 10;
            const int expectedResult = 3650;

            //act
            var actualResult = AgeConversor.AgeToDays(age);

            //assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}