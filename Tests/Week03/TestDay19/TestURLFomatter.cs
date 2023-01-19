using Xunit;
using Day19;

namespace TestDay19
{
    public class TestURLFomatter
    {
        [Theory(DisplayName = "")]
        [InlineData("https://stackoverflow.com/questions/11454004/calculate-a-md5-hash-from-a-string")]
        public void TestURLShortenerStart(string inputData)
        {
            var actualResult = URLFormatter.URLShortener(inputData);

            Assert.StartsWith("http://urlshort.nr/", actualResult);
        }

        [Theory(DisplayName = "")]
        [InlineData("https://stackoverflow.com/questions/11454004/calculate-a-md5-hash-from-a-string")]
        public void TestURLShortenerLength(string inputData)
        {
            
            var regEx = @"^.{1,200}$";
            var actualResult = URLFormatter.URLShortener(inputData);

            Assert.Matches(regEx, actualResult);
        }

        
    }
}