using Xunit;
using Day48;

namespace TestDay48;

public class UnitTestDrawer
{
    [Theory]
    [InlineData(0, new string[] {})]
    [InlineData(2, new string[] {
        " * ",
        "***"
    })]
    [InlineData(5, new string[] {
        "    *    ",
        "   ***   ",
        "  *****  ",
        " ******* ",
        "*********",
    })]
    public void TestTree(int height, string[] expectedResult)
    {
        var actualResult = Drawer.Tree(height);

        Assert.Equal(expectedResult, actualResult);
    }
}