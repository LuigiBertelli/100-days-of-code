using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;
using Day35.helper;

namespace Day35
{
    public class Gopher
    {

        private bool isBadFile;
        private string[] fileLines = new string[0];

        private const string curPath = @"C:\Luigi\100DaysOfCode\Main\Week05\Day35\assets\";
        public Gopher(string filename)
        {
            try{
                fileLines = System.IO.File.ReadLines($"{curPath}{filename}").ToArray();
                isBadFile = false;
            } catch(Exception ex) {
                isBadFile = true;
            }
            
        }

        public string[] gopherEscapePlan()
        {
            try {
                if(isBadFile)
                    throw new Exception("Bad File");

                var results = new List<string>();
                int curLine = 0;
                int lastMain = -2;
            
                while(curLine < fileLines.Length) {
                    var main = fileLines[curLine];

                    if(string.IsNullOrWhiteSpace(main) || curLine - lastMain < 2){
                        curLine++;
                        continue;
                    }

                    var splitted = main.Split(' ');

                    if(splitted.Length != 5) {
                        throw new Exception("Invalid input data");
                    }

                    var holes = Int32.Parse(splitted[0]);



                    // Gopher position
                    var posGp = (double.Parse(splitted[1], NumberStyles.Any, CultureInfo.InvariantCulture), double.Parse(splitted[2], NumberStyles.Any, CultureInfo.InvariantCulture));

                    // Dog position
                    var posDog = (double.Parse(splitted[3], NumberStyles.Any, CultureInfo.InvariantCulture), double.Parse(splitted[4], NumberStyles.Any, CultureInfo.InvariantCulture));

                    
                    curLine++;
                    var max = curLine + holes;
                    var canEscape = false;

                    while(curLine < max) {
                        var set = fileLines[curLine];
                        var splittedSet = set.Split(' ');
                        
                        if(splittedSet.Length != 2) {
                            throw new Exception("Invalid set");
                        }

                        (double x, double y) hole = (double.Parse(splittedSet[0], NumberStyles.Any, CultureInfo.InvariantCulture), double.Parse(splittedSet[1], NumberStyles.Any, CultureInfo.InvariantCulture));

                        var distDog = PositionHelper.Distance(posDog, hole);
                        var distGopher = PositionHelper.Distance(posGp, hole);

                        if(!canEscape && distGopher < distDog / 2) {
                            results.Add($"The gopher can escape through the hole at ({splittedSet[0]},{splittedSet[1]}).");
                            canEscape = true;
                        }

                        curLine++;                        
                    }

                    if(!canEscape) {
                        results.Add("The gopher cannot escape.");
                    }
                }
                
                return results.ToArray();
            } catch(Exception ex) {
                return new string[]{"BAD FILE!"};
            }
        }
    }
}