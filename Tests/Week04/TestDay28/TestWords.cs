using Xunit;
using Day28;

namespace TestDay28;

public class TestWords
{
    [Fact]
    public void TestWordSearcher()
    {
        var board = new char[,] { 
                {'o','a','a','n'}, 
                {'e','t','a','e'}, 
                {'i','h','k','r'},
                {'i','f','l','v'} };
            
        var words = new string[] {"oath","pea","eat","rain"};

        var expectedResult = new string[] {"oath","eat"};

        var actualResult = Words.WordSearcher(board, words).ToArray();

        Assert.Equal(expectedResult, actualResult);
    }
}