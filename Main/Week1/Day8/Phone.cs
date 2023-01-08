using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day8
{
    public class Phone
    {

        //Phone digits
        private static Dictionary<char, string[]> _digits = new Dictionary<char, string[]>()
        {
            { '2', new string[3]{"a","b","c"} },
            { '3', new string[3]{"d","e","f"} },
            { '4', new string[3]{"g","h","i"} },
            { '5', new string[3]{"j","k","l"} },
            { '6', new string[3]{"m","n","o"} },
            { '7', new string[4]{"p","q","r","s"} },
            { '8', new string[3]{"t","u","v"} },
            { '9', new string[4]{"w","x","y","z"} }

        };
        
        //Return all possible letter combinations typed
        public static string[] Typing(string typed)
        {
            List<string> recursiveArrangeWords(List<string> actualArray, string[] nextArray){
                var auxArray = new List<string>();
                for(int i = 0; i < actualArray.Count(); i++){
                    for(int j = 0; j < nextArray.Length; j++)
                        auxArray.Add(actualArray[i] + nextArray[j]);
                }

                return auxArray;
            }

            
            List<string> output = new List<string>();

            for(int h = 0; h < typed.Length; h++){
                _digits.TryGetValue(typed[h], out string[] letters);
                if(h == 0) {
                    output.AddRange(letters);
                } else {
                    output = recursiveArrangeWords(output, letters);
                }
            }

            return output.ToArray();
        }

    }
}