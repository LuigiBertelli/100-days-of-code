using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day27
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int interval = 2;

            var tasks = new string[]{"A","A","A","A","A","A","B","C","D","E","F","G"};

            Console.WriteLine(new Day27.TaskScheduler(tasks, interval).TasksTime());
        }
    }
}