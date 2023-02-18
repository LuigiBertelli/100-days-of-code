using Xunit;
using Day49;

namespace TestDay49;

public class UnitTest1
{
    [Fact]
    public void TestIsLegitimateTrue()
    {
        var backyard = new int[5][]{
            new int[] {0, 0, 0, 0, 0, 0, 0, 0},
            new int[] {0, 1, 1, 1, 1, 1, 0, 0},
            new int[] {0, 1, 1, 1, 1, 1, 0, 0},
            new int[] {0, 1, 1, 0, 0, 0, 0, 0},
            new int[] {0, 0, 0, 0, 0, 0, 0, 0}
        };
        var pool = new Pool(backyard);

        var actualResult = pool.IsLegitimate();

        Assert.True(actualResult);
    }

    [Fact]
    public void TestIsLegitimateFalse()
    {
        var backyard = new int[][]{
            new int[] {0, 0, 0, 0, 0, 0, 0, 0},
            new int[] {0, 0, 1, 1, 1, 0, 0, 0},
            new int[] {0, 1, 1, 1, 1, 1, 0, 0},
            new int[] {0, 0, 1, 1, 1, 0, 0, 0}
        };
        var pool = new Pool(backyard);

        var actualResult = pool.IsLegitimate();

        Assert.False(actualResult);
    }
}