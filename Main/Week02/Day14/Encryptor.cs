using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace Day14
{
    public class Encryptor
    {
        public string _baseStr {get; protected set;}

        public Encryptor(string baseStr)
        {
            _baseStr = baseStr.Trim().ToLower();
        }

        /// <summary>
        /// Function that encrypt prop _baseStr with Karaca's method
        /// Input: "apple"
        /// Step 1: Reverse the input: "elppa"
        /// Step 2: Replace all vowels using the following chart: "1lpp0"
        ///      a => 0
        ///      e => 1
        ///      i => 2
        ///      o => 2
        ///      u => 3
        ///  Step 3: Add "aca" to the end of the word: "1lpp0aca"
        ///</summary>
        /// <returns>prop _baseStr encoded</returns>
        public string KaracasEncode() {

            if(!string.IsNullOrEmpty(_baseStr)) {
                string[] preEncodedSplitted = new string(_baseStr.ToCharArray().Reverse().ToArray())
                    .Replace('a', '0')
                    .Replace('e', '1')
                    .Replace('u', '3')
                    .Split(new char[]{'i', 'o'});
                return string.Concat(string.Join('2', preEncodedSplitted), "aca");
            } else
                return "";
        }

        /// <summary>
        /// Function that decrypt strings with Karaca's method
        /// Input: "1lpp0aca"
        /// Step 1: Remove "aca" from the end of the word: "1lpp0"
        /// Step 2: Reverse the input: "0ppl1"
        /// Step 3: Replace all vowels using the following chart: "apple"
        ///      a => 0
        ///      e => 1
        ///      i => 2
        ///      o => 2
        ///      u => 3
        ///</summary>
        /// <param name="encodedStr">base string to be decrypted</param>
        /// <returns>possibles decoded string</returns>
        public string[] KaracasDecode(string encodedStr)
        {

            string firstPartDecode = new string(encodedStr.Trim().Replace("aca", "").ToCharArray().Reverse().ToArray())
                .Replace('0', 'a')
                .Replace('1', 'e')
                .Replace('3', 'u');
            
            if(firstPartDecode.Contains("2")) {
                int count = firstPartDecode.Count(x => x == '2');
                int max = (int) Math.Pow(2.0d, (double) count);
                string[] decodeStr = new string[max];

                for(int i = 0; i < max; i++) {
                    char[] word = firstPartDecode.ToCharArray();
                    int lastIdx = firstPartDecode.IndexOf('2');
                    BitArray bits = new BitArray(new int[]{i});

                    for(int j = 0; j < count; j++) {
                        word.SetValue(( j < bits.Length && bits[j]? 'i': 'o'), lastIdx);
                        lastIdx = firstPartDecode.IndexOf('2', lastIdx + 1);
                    } 

                    decodeStr[i] = new string(word);
                }

                return decodeStr;
            } else
                return new string[]{firstPartDecode};
        }
        
    }
}