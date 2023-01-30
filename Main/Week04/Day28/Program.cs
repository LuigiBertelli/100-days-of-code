using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day28
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var board = new char[,] { 
                {'o','a','a','n'}, 
                {'e','t','a','e'}, 
                {'i','h','k','r'},
                {'i','f','l','v'} };
            
            var words = new string[] {"oath","pea","eat","rain"};

            var test = Words.WordSearcher(board, words);

            foreach(var i in test)
                Console.WriteLine(i);
        }
    }
}