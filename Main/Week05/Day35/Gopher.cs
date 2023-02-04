using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Day35.helper;

namespace Day35
{
    public class Gopher
    {

        private bool isBadFile;
        private string[] fileLines;

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
                    var posGp = (float.Parse(splitted[1]), float.Parse(splitted[2]));

                    // Dog position
                    var posDog = (float.Parse(splitted[3]), float.Parse(splitted[4]));

                    
                    curLine++;
                    Console.WriteLine(holes);
                    while(curLine < curLine + holes) {
                        var set = fileLines[curLine];
                        var splittedSet = set.Split(' ');
                        
                        Console.WriteLine(curLine);
                        foreach(var it in splittedSet) Console.WriteLine(it);
                        //Console.WriteLine(splittedSet.Length);
                        if(splittedSet.Length != 2) {
                            throw new Exception("Invalid set");
                        }

                        (float x, float y) hole = (float.Parse(splittedSet[0]), float.Parse(splittedSet[1]));

                        var distDog = PositionHelper.Distance(posDog, hole);
                        var distGopher = PositionHelper.Distance(posGp, hole);

                        if(distGopher > distDog * 2) {
                            results.Add($"The gopher can escape through the hole at ({hole.x},{hole.y}).");
                        } else {
                            results.Add("The gopher cannot escape.");
                        }

                        curLine++;
                    }
                }
                
                return results.ToArray();
            } catch(Exception ex) {
                return new string[]{"BAD FILE!"};
            }
        }
    }
}