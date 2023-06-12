using Xunit;
using Day69;

namespace TestDay69
{
    public class UnitTestGarageDoorOpener
    {
        [Theory]
        [InlineData(new string[8] {"button_clicked", "cycle_complete", "button_clicked", "button_clicked",
            "button_clicked", "button_clicked", "button_clicked", "cycle_complete"}, "CLOSED")]
        public void TestButton(string[] input, string expectedResult)
        {
            var actualResult = GarageDoorOpener.Button(input);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}