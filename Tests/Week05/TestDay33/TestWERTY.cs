using Xunit;
using Day33;

namespace TestDay33;

public class TestWERTY
{
    [Theory]
    [InlineData("O S, GOMR YPFSU;", "I AM FINE TODAY.")]
    public void TestKeyboardMistakeFix(string input, string expectedResult)
    {
        var actualResult = WERTY.KeyboardMistakeFix(input);

        Assert.Equal(expectedResult, actualResult);
    }
}