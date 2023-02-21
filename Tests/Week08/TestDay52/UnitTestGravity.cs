using Xunit;
using Day52;

namespace TestDay52;

public class UnitTestGravity
{
    [Fact]
    public void TestSwitchGravityOnTest1()
    {
        string[,] blocks = new string[,] {
            {"-", "#", "#", "-"},
            {"-", "-", "-", "-"},
            {"-", "-", "-", "-"},
            {"-", "-", "-", "-"}};
        string[,] expectedResult = new string[,] {
            {"-", "-", "-", "-"},
            {"-", "-", "-", "-"},
            {"-", "-", "-", "-"},
            {"-", "#", "#", "-"}
        };


        var actualResult = Gravity.SwitchGravityOn(blocks);

        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void TestSwitchGravityOnTest2()
    {
        string[,] blocks = new string[,] {
            {"-", "#", "#", "-"},
            {"-", "-", "#", "-"},
            {"-", "-", "-", "-"}};
        string[,] expectedResult = new string[,] {
            {"-", "-", "-", "-"},
            {"-", "-", "#", "-"},
            {"-", "#", "#", "-"}
        };


        var actualResult = Gravity.SwitchGravityOn(blocks);

        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void TestSwitchGravityOnTest3()
    {
        string[,] blocks = new string[,] {
            {"-", "#", "#", "#", "#", "-"},
            {"#", "-", "-", "#", "#", "-"},
            {"-", "#", "-", "-", "-", "-"},
            {"-", "-", "-", "-", "-", "-"}};
        string[,] expectedResult = new string[,] {
            {"-", "-", "-", "-", "-", "-"},
            {"-", "-", "-", "-", "-", "-"},
            {"-", "#", "-", "#", "#", "-"},
            {"#", "#", "#", "#", "#", "-"}
        };


        var actualResult = Gravity.SwitchGravityOn(blocks);

        Assert.Equal(expectedResult, actualResult);
    }
}