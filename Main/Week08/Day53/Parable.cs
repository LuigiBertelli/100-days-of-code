using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day53
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Parable.JavelinThrow(36.7, 45));
        }
    }

    public class Parable
    {
        public static string JavelinThrow(double vel, double angle)
        {
            const double gravity = -9.81;
            var rad = angle * (Math.PI / 180);
            var voY = Math.Sin(rad) * vel;
            var voX = Math.Cos(rad) * vel;

            var time = -voY / gravity;
            
            var YMax = (int) Math.Round(voY * time + (gravity / 2) * (time * time));
            var XMax = (int) Math.Round(voX * 2 * time);

            Console.WriteLine((voY * voY) / (-2 * gravity));

            return $"Ymax={YMax}m, Xmax={XMax}m";
        }
    }
}