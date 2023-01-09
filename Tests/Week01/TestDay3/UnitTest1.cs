using Day3;

namespace TestDay3
{
    public class UnitTest1
    {
        [Theory(DisplayName = "")]
        //arrange
        [InlineData(
            new string[]{
                "--xo--x--ox--", 
                "-xx--x--xx--",
                "-oo--o--oo--", // <<< Vegeterian Skewer
                "-xx--x--ox--",
                "-xx--x--ox--"
            },
            new int[]{1, 4 } // 1 Vegetarian and 4 Non-Vegetarian
            )]
        [InlineData(
            new string[]{
                "--oooo-ooo--", // <<< Vegeterian Skewer
                "--xx--x--xx--",
                "--o---o--oo--", // <<< Vegeterian Skewer
                "--xx--x--ox--",
                "--xx--x--ox--"
            },
            new int[] { 2, 3 } // 2 Vegetarian and 3 Non-Vegetarian
            )]
        [InlineData(
            new string[]{
                "--oooo-ooo--", // <<< Vegeterian Skewer
                "--xxxxxxxx--",
                "--o-", // <<< Vegeterian Skewer
                "--o---x--ox--",
                "--oo--o--oo--" // <<< Vegeterian Skewer
            },
            new int[] { 3, 2 } // 3 Vegetarian and 2 Non-Vegetarian
            )]
        [InlineData(
            new string[]{}, // No skew
            new int[] {0, 0} // 0 skews for both
            )]
        public void Test1(string[] input, int[] expectedResult)
        {
            //act
            var actualResult = Barbecue.VegOrNot(input);

            //assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}