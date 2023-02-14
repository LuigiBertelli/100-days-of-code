using Xunit;
using Day42;

namespace TestDay42;

public class UnitTestBook
{
    [Fact]
    public void TestMinPages()
    {
        const int n = 5;
        const int p = 3;
        const int expectedResult = 1;

        var actualResult = Book.MinPages(n, p);

        Assert.Equal(expectedResult, actualResult);
    }
}