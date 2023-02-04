using System;

namespace Day35
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var gopher1 = new Gopher("day-35_sample_1_valid.txt");
            var gopher1Results = gopher1.gopherEscapePlan();
            foreach(var it in gopher1Results) Console.WriteLine(it);

            var gopher2 = new Gopher("day-35_sample_2_valid.txt");
            var gopher2Results = gopher2.gopherEscapePlan();
            foreach(var it in gopher2Results) Console.WriteLine(it);

            // var gopher3 = new Gopher("day-35_sample_3_invalid.txt");
            // var gopher3Results = gopher3.gopherEscapePlan();
            // foreach(var it in gopher3Results) Console.WriteLine(it);

            // var gopher4 = new Gopher("day-35_sample_4_invalid.txt");
            // var gopher4Results = gopher4.gopherEscapePlan();
            // foreach(var it in gopher4Results) Console.WriteLine(it);

            // var gopher5 = new Gopher("day-35_sample_5_invalid.txt");
            // var gopher5Results = gopher5.gopherEscapePlan();
            // foreach(var it in gopher5Results) Console.WriteLine(it);
        }
    }
}