using Xunit;
using Day14;

namespace TestDay14
{
    public class TestEncryptor
    {
        [Theory(DisplayName = "When baseStr is a valid string result is success")]
        [InlineData("", "")]
        [InlineData("banana", "0n0n0baca")]
        [InlineData("apple", "1lpp0aca")]
        [InlineData("karaca", "0c0r0kaca")]
        [InlineData("burak", "k0r3baca")]
        [InlineData("alpaca", "0c0pl0aca")]
        [InlineData("choice", "1c22hcaca")]
        public void TestKaracasEncode(string baseStr, string expectedEncodedStr)
        {
            var actualEncodedStr = new Encryptor(baseStr).KaracasEncode();

            Assert.Equal(expectedEncodedStr, actualEncodedStr);
        }

        [Theory(DisplayName = "When encodedStr is a valid string result is success")]
        [InlineData("", new string[]{""})]
        [InlineData("0n0n0baca", new string[]{"banana"})]
        [InlineData("1lpp0aca", new string[]{"apple"})]
        [InlineData("0c0r0kaca", new string[]{"karaca"})]
        [InlineData("k0r3baca", new string[]{"burak"})]
        [InlineData("0c0pl0aca", new string[]{"alpaca"})]
        [InlineData("1c22hcaca", new string[]{"chooce", "chioce", "choice", "chiice"})]
        public void TestKaracasDecode(string encodedStr, string[] expectedDecodedStr)
        {
            var actualDecodedStr = new Encryptor("").KaracasDecode(encodedStr);

            Assert.Equal(expectedDecodedStr, actualDecodedStr);
        }
    }
}