using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day12
{
    public class Landscape
    {
        public static string LandscapeType(int[] landscapeArray)
        {
            bool Increasing(int[] auxArray) {
                int aux = auxArray[0];
                for(int i = 1; i < auxArray.Length; i++) {
                    if(auxArray[i] < aux)
                        return false;

                    aux = auxArray[i];
                }

                return true;
            }

            bool Decreasing(int[] auxArray) {
                int aux = auxArray[0];
                for(int i = 1; i < auxArray.Length; i++) {
                    if(auxArray[i] > aux)
                        return false;

                    aux = auxArray[i];
                }

                return true;
            }

            List<int> landscapeList = landscapeArray.ToList();

            if(landscapeArray.Count(x => x == landscapeArray.Max()) == 1) {
                int peak = Array.IndexOf(landscapeArray, landscapeArray.Max());

                if(peak > 0 && peak < landscapeArray.GetUpperBound(0) && Increasing(landscapeList.GetRange(0, peak + 1).ToArray()) && Decreasing(landscapeList.GetRange(peak, landscapeArray.Length - peak - 1).ToArray()))
                    return "mountain";
            }
            
            if(landscapeArray.Count(x => x == landscapeArray.Min()) == 1) {
                int trough = Array.IndexOf(landscapeArray, landscapeArray.Min());
                if(trough > 0 && trough < landscapeArray.GetUpperBound(0) && Decreasing(landscapeList.GetRange(0, trough + 1).ToArray()) && Increasing(landscapeList.GetRange(trough, landscapeArray.Length - trough - 1).ToArray()))
                    return "valley";
            }
            
            return "neither";
        }
    }
}