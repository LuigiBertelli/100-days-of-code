using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day15
{
    public class Anagram
    {
        public static bool IsAnagram(string baseStr, string possibleAnagram)
        {
            char[] baseCharArray = baseStr.Trim().ToLower().ToCharArray();
            List<char> anagramCharList= possibleAnagram.Trim().ToLower().ToList();

            if(baseCharArray.Length == anagramCharList.Count()) {
                foreach(char aux in baseCharArray) {
                    int idx = anagramCharList.IndexOf(aux);

                    if(idx >= 0)
                        anagramCharList.RemoveAt(idx);
                }

                if(anagramCharList.Count() == 0)
                    return true;
            }
            
            return false;
        }
    }
}