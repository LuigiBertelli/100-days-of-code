using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day29
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = (string?) Console.ReadLine();

            var splittedInput = input?.ToUpper().Split(' ') ?? new string[0];

            var allowedLetters = new string[] {"R", "G", "Y", "P", "C", "X"};

            if(splittedInput.Length > 0 && splittedInput.Length <= 15 && splittedInput.Where(x => !allowedLetters.Contains(x)).Count() == 0 ) {
                string lastLetter = string.Empty;
                bool accept = true;
                if(splittedInput[0] == "R") {
                    foreach(var state in splittedInput) {
                        if(!string.IsNullOrEmpty(lastLetter)) {
                            switch(lastLetter) {
                                case "R": 
                                    if(state == "R" || state == "Y")
                                        accept = false;
                                    break;
                                case "G": 
                                    if(state == "G" || state == "R")
                                        accept = false;
                                    break;
                                case "Y": 
                                    if(state == "Y" || state == "G")
                                        accept = false;
                                    break;
                                case "X": 
                                    accept = false;
                                    break;
                            }
                        }

                        lastLetter = state;

                        if(!accept)
                            break;
                    }
                } else
                    accept = false;

                if(accept)
                    Console.WriteLine("Accept");
                else
                    Console.WriteLine("Reject");
            } else
                Console.WriteLine("Error");
        }
    }
}