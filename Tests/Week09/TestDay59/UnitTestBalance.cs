using Xunit;
using Day59;

namespace TestDay59;

public class UnitTestBalance
{
    [Theory]
    [InlineData("xxxyyyzzz")]
    [InlineData("abccbaabccba")]
    [InlineData("abcdefghijklmnopqrstuvwxyz")]
    [InlineData("www")]
    [InlineData("x")]
    [InlineData("")]
    public void TestBalanceBonusTrue(string input)
    {
        var actualResult = Balance.BalancedBonus(input);

        Assert.True(actualResult);
    }

    [Theory]
    [InlineData("xxxyyyzzzz")]
    [InlineData("pqq")]
    [InlineData("fdedfdeffeddefeeeefddf")]
    public void TestBalanceBonusFalse(string input)
    {
        var actualResult = Balance.BalancedBonus(input);

        Assert.False(actualResult);
    }
}