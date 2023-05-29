using Xunit;
using Day54;

namespace TestDay54;

public class UnitTextRGB2HexConverter
{
    [Theory]
    [InlineData("rgb(0, 128, 192)", "#0080c0")]
    [InlineData("rgb(45, 255, 192)", "#2dffc0")]
    [InlineData("rgb(0, 0, 0)", "#000000")]
    public void TestRGB2HexConverte(string input, string expectedResult)
    {
        var actualResult = RGB2HexConverter.RgbToHex(input);

        Assert.Equal(expectedResult, actualResult);
    }
}