using Xunit;
using Day65;

namespace TestDay65
{
    public class UnitTestISBN
    { 
        [Theory]
        [InlineData("0-7475-3269-9")]
        [InlineData("156881111X")]
        public void TestValidatorTrue(string code)
        {
            var result = ISBN.Validator( code );

            Assert.True( result );
        }

        [Theory]
        [InlineData("--7475-3269-9")]
        [InlineData("0-7475-3269-91")]
        public void TestValidatorFalse(string code)
        {
            var result = ISBN.Validator(code);

            Assert.False(result);
        }
    }
}