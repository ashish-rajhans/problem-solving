using System;
using System.Collections.Generic;
using System.Text;

//https://codeforces.com/contest/1520/problem/A
namespace DotNetSolutions
{
    class NoDistractions
    {
        public NoDistractions()
        {
            int t;
            t = Convert.ToInt32(Console.In.ReadLine());
            List<string> output = new List<string>();
            for (int i = 0; i < t; i++)
            {
                int n;
                n = Convert.ToInt32(Console.In.ReadLine());

                string tasks = Console.ReadLine();
                
                output.Add(isSuspicious(tasks));
            }

            foreach (var val in output)
            {
                Console.Out.WriteLine(val);
            }
        }

        private string isSuspicious(string tasks)
        {
            if (tasks.Length <= 1)
            {
                return "YES";
            }

            HashSet<char> prevTasks = new HashSet<char>();
            char prevTask = tasks[0];
            prevTasks.Add(prevTask);
            for (int i = 1; i < tasks.Length; i++)
            {
                if (prevTask != tasks[i])
                {
                    if (prevTasks.Contains(tasks[i]))
                    {
                        return "NO";
                    }
                    else
                    {
                        prevTasks.Add(tasks[i]);
                    }
                }
                prevTask = tasks[i];
            }

            return "YES";
        }
    }
}
