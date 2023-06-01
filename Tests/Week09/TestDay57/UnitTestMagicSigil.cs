using Xunit;
using Day57;

namespace TestDay57;

public class UnitTestMagicSigil
{
    [Theory]
    [InlineData("AUFRINDSWHLOVME", "FRNDSWHLVM")]
    [InlineData("i am healthy", "MLTHY")]
    [InlineData("I FOUND MY SOULMATE", "FNDYSLMT")]
    [InlineData("I have a job I enjoy and it pays well", "HVBJNDTPYSWL")]
    public void TestSigilize(string input, string expectedResult)
    {
        var newMagicSigil = new MagicSigil(input);
        var actualResult = newMagicSigil.Sigilize();    

        Assert.Equal(expectedResult, actualResult);
    }
}