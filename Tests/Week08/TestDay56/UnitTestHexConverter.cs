using Xunit;
using Day56;

namespace TestDay56;

public class UnitTestHexConverter
{
    [Theory]
    [InlineData("hello world", "68 65 6c 6c 6f 20 77 6f 72 6c 64")]
    [InlineData("Big Boi", "42 69 67 20 42 6f 69")]
    [InlineData("Marty Poppinson", "4d 61 72 74 79 20 50 6f 70 70 69 6e 73 6f 6e")]
    public void TestConvertStr2ASCII(string input, string expectedResult)
    {
        var actualResult = HexConverter.ConvertStr2ASCII(input);

        Assert.Equal(expectedResult, actualResult);
    }
}