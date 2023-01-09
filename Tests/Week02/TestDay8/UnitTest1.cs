using Xunit;
using Day8;

namespace TestDay8{

    public class TestPhone
    {
        private void assertTyping(string inputData, string[] expectedResult) {
            var actualResult = Phone.Typing(inputData);

            Assert.Equal(expectedResult, actualResult);
        } 



        [Theory(DisplayName = "When input is a valid numeric string between 2 - 9 (lenght = 1), return success")]
        [InlineData("2", new string[3]{"a","b","c"})]
        [InlineData("3", new string[3]{"d","e","f"})]
        [InlineData("4", new string[3]{"g","h","i"})]
        [InlineData("5", new string[3]{"j","k","l"})]
        [InlineData("6", new string[3]{"m","n","o"})]
        [InlineData("7", new string[4]{"p","q","r","s"})]
        [InlineData("8", new string[3]{"t","u","v"})]
        [InlineData("9", new string[4]{"w","x","y","z"})]
        public void TestTyping1Digit(string inputData, string[] expectedResult) => assertTyping(inputData, expectedResult);


        [Theory(DisplayName = "When input is a valid numeric string between 2 - 9 (lenght = 2), return success")]
        [InlineData("23", new string[9]{"ad","ae","af","bd","be","bf","cd","ce","cf"})]
        [InlineData("34", new string[9]{"dg","dh","di","eg","eh","ei","fg","fh","fi"})]
        [InlineData("45", new string[9]{"gj","gk","gl","hj","hk","hl","ij","ik","il"})]
        [InlineData("78", new string[12]{"pt","pu","pv","qt","qu","qv","rt","ru","rv","st","su","sv"})]
        [InlineData("92", new string[12]{"wa","wb","wc","xa","xb","xc","ya","yb","yc","za","zb","zc"})]
        public void TestTyping2Digit(string inputData, string[] expectedResult) => assertTyping(inputData, expectedResult);


        [Theory(DisplayName = "When input is a valid numeric string between 2 - 9 (lenght = 3), return success")]
        [InlineData("234", new string[27]{"adg","adh","adi","aeg","aeh","aei","afg","afh","afi","bdg","bdh","bdi","beg","beh","bei",
            "bfg","bfh","bfi","cdg","cdh","cdi","ceg","ceh","cei","cfg","cfh","cfi"})]
        [InlineData("567", new string[36]{"jmp","jmq","jmr","jms","jnp","jnq","jnr","jns","jop","joq","jor","jos",
            "kmp","kmq","kmr","kms","knp","knq","knr","kns","kop","koq","kor","kos",
            "lmp","lmq","lmr","lms","lnp","lnq","lnr","lns","lop","loq","lor","los"})]
        [InlineData("892", new string[36]{"twa","twb","twc","txa","txb","txc","tya","tyb","tyc","tza","tzb","tzc",
            "uwa","uwb","uwc","uxa","uxb","uxc","uya","uyb","uyc","uza","uzb","uzc",
            "vwa","vwb","vwc","vxa","vxb","vxc","vya","vyb","vyc","vza","vzb","vzc"})]
        public void TestTyping3Digit(string inputData, string[] expectedResult) => assertTyping(inputData, expectedResult);


        [Theory(DisplayName = "When input is a valid numeric string between 2 - 9 (lenght = 4), return success")]
        [InlineData("2345", new string[81]{
            "adgj","adgk","adgl","adhj","adhk","adhl","adij","adik","adil",
            "aegj","aegk","aegl","aehj","aehk","aehl","aeij","aeik","aeil",
            "afgj","afgk","afgl","afhj","afhk","afhl","afij","afik","afil",
            "bdgj","bdgk","bdgl","bdhj","bdhk","bdhl","bdij","bdik","bdil",
            "begj","begk","begl","behj","behk","behl","beij","beik","beil",
            "bfgj","bfgk","bfgl","bfhj","bfhk","bfhl","bfij","bfik","bfil",
            "cdgj","cdgk","cdgl","cdhj","cdhk","cdhl","cdij","cdik","cdil",
            "cegj","cegk","cegl","cehj","cehk","cehl","ceij","ceik","ceil",
            "cfgj","cfgk","cfgl","cfhj","cfhk","cfhl","cfij","cfik","cfil"})]
        public void TestTyping4Digit(string inputData, string[] expectedResult) => assertTyping(inputData, expectedResult);

    }
}