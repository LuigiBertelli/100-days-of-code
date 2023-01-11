using Xunit;
using Day10;

namespace TestDay10
{
    public class TestBinarySearchTree
    {
        [Theory(DisplayName = "When input is a valid int the test returns success")]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 5)]
        public void TestCountUniqueBST(int inputData, int expectedResult)
        {
            var actualResult = new BinarySearchTree().CountUniqueBST(inputData);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}