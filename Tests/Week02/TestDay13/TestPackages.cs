using Xunit;
using Day13;

namespace TestDay13{
    public class TestDay13
    {
        [Theory]
        [InlineData(new int[] { 2, 1, 2, 5, 4, 3, 6, 1, 1, 9, 3, 2 }, 4)]
        public void TestCanFitResultingTrue(int[] itemsWeight, int packagesNumber)
        {
            var actualResult = Packages.CanFit(itemsWeight, packagesNumber);

            Assert.True( actualResult);
        }

        [Theory]
        [InlineData(new int[] { 2, 7, 1, 3, 3, 4, 7, 4, 1, 8, 2 }, 4)]
        public void TestCanFitResultingFalse(int[] itemsWeight, int packagesNumber)
        {
            var actualResult = Packages.CanFit(itemsWeight, packagesNumber);

            Assert.False( actualResult);
        }
    }
}