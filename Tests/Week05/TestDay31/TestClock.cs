using Xunit;
using Day31;

namespace TestDay31;

public class TestClock
{
    [Theory]
    [InlineData(11, 0, "eleven o'clock")]
    [InlineData(11, 10, "ten past eleven")]
    [InlineData(11, 15, "quarter past eleven")]
    [InlineData(11, 20, "twenty past eleven")]
    [InlineData(11, 30, "half past eleven")]
    [InlineData(11, 40, "twenty to twelve")]
    [InlineData(11, 45, "quarter to twelve")]
    [InlineData(11, 50, "ten to twelve")]
    [InlineData(12, 0, "twelve o'clock")]
    [InlineData(12, 10, "ten past twelve")]
    [InlineData(12, 15, "quarter past twelve")]
    [InlineData(12, 20, "twenty past twelve")]
    [InlineData(12, 30, "half past twelve")]
    [InlineData(12, 40, "twenty to one")]
    [InlineData(12, 45, "quarter to one")]
    [InlineData(12, 50, "ten to one")]

    public void TestWhatTimeIsIt(int hour, int min, string expectedResult)
    {
        var actualResult = Clock.WhatTimeIsIt(hour, min);

        Assert.Equal(expectedResult, actualResult);
    }
}