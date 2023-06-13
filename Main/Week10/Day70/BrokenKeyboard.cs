using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day70
{
    public class BrokenKeyboard
    {
        private const string DICT_PATH = "C:/Users/berte/My Projects/100DaysOfCode/100-days-of-code/Main/Week10/Day70/Assets/Dictionary1.txt";
        public char[] WorkingLetters { get; private set; }

        public BrokenKeyboard(string letters)
        {
            WorkingLetters = letters.ToCharArray();
        }


        public BrokenKeyboard(char[] letters)
        {
            WorkingLetters = letters;
        }

        public string LongestWord()
        {
            var stream = new StreamReader(DICT_PATH);

            var longestWord = string.Empty;

            while(!stream.EndOfStream) 
            {
                var word = stream.ReadLine();
                if(word.ToCharArray().Where(letter => !WorkingLetters.Contains(letter)).Count() == 0 
                    && word.Length > longestWord.Length)
                    longestWord = word;
            }
            
            return longestWord;
        }
    }
}
