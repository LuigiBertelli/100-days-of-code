using Xunit;
using Day22;

namespace TestDay22;

public class TextExtension
{
    [Theory]
    [InlineData(1034, 145)]
    [InlineData(9054, 1268)]
    public void TestCalcExtensionInFootballFields(int extension, long expectedResult)
    {
        var actualResult = Extension.CalcExtensionInFootballFields(extension);

        Assert.Equal(expectedResult, actualResult);
    }
}