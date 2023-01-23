using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day21
{
    public class Maze
    {
        public static void DrawMaze(int n, int m)
        {
            int rowMax = (n * 3) + 1;
            int colMax = (m * 4) + 1;

            List<string> strCharMat = new List<string>();
            List<List<int>> closedCols = new List<List<int>>();

            for(int i = 0; i < rowMax; i++) {
                var rand = new Random();
                List<char> row = new List<char>();
                closedCols.Add(new List<int>());

                if(i % 3 == 0) {
                    bool isClosedRow = false;
                    for(int j = 0; j < colMax; j++) {
                        char aux = ' ';

                        if(j % 4 == 1)
                            isClosedRow = rand.NextInt64(10) % 2 == 0;

                        if(j % 4 == 0)
                            aux = '+';
                        else if(i == 0 || i == rowMax - 1 || isClosedRow)
                            aux = '-';

                        row.Add(aux);
                    }
                } else if(i % 3 == 1) {
                    List<int> cls = new List<int>();
                    for(int j = 0; j < colMax; j++) {
                        var rndm = new Random();
                        bool isClosedCol = j == 0 || j == colMax - 1 || (j % 4 == 0 && rndm.NextInt64(10) % 2 == 0);
                        char aux = ' ';

                        if(isClosedCol) {
                            aux = '|';
                            cls.Add(j);
                        }

                        row.Add(aux);
                    }

                    closedCols[i] = cls;
                } else {
                    for(int j = 0; j < colMax; j++) {
                        char aux = ' ';
                        bool isClosedCol = j == 0 || j == colMax - 1 || closedCols[i - 1].Contains(j);

                        if(isClosedCol)
                            aux = '|';
                        
                        row.Add(aux);
                    }
                }

                strCharMat.Add(new string(row.ToArray()));
            }

            for(int k = 0; k < strCharMat.Count(); k++) {
                Console.WriteLine(strCharMat[k]);
            }

        }
    }
}