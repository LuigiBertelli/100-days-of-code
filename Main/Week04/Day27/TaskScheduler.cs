using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day27
{
    public class TaskScheduler
    {
        private string[] _tasks;
        private int _interval;

        public TaskScheduler(string[] tasks, int interval)
        {
            _tasks = tasks;

            _interval = interval;
        }

        public int TasksTime(int? interval = null)
        {
            interval = interval ?? _interval;

            List<string> tasksList = _tasks.ToList();
            Dictionary<string, int> taskInterval = new Dictionary<string, int>();
            int cont = 0;

            while(tasksList.Count > 0) {
                string? task = tasksList.Find(x => {
                    if(taskInterval.ContainsKey(x) && taskInterval[x] > 0)
                        return false;
                    else    
                        return true;
                });



                cont++;

                foreach(var node in taskInterval) {
                    taskInterval[node.Key] -= 1;
                }

                if(!string.IsNullOrEmpty(task)) {
                    
                    if(!taskInterval.ContainsKey(task))
                        taskInterval.Add(task, _interval);
                    else
                        taskInterval[task] = _interval;

                    tasksList.Remove(task);
                }
            }

            return cont;
        }
        
    }
}