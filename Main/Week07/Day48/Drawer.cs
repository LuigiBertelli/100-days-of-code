using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Day48
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const int height = 5;
            var tree = Drawer.Tree(height);

            foreach(var it in tree) {
                Console.WriteLine(it);
            }
        }
    }

    public class Drawer
    {
        public static string[] Tree(int height)
        {
            var tree = new string[height];
            var len = 2 * height - 1;

            for(int i = 0; i < height; i++) {
                var blocks = 2 * i + 1;
                var fill = (len - blocks) / 2;
                var sb = new StringBuilder();
                sb.Append(' ', fill);
                sb.Append('*', blocks);
                sb.Append(' ', fill);
                tree[i] = sb.ToString();
                blocks += 2;
            }

            return tree;
        }
    }
}