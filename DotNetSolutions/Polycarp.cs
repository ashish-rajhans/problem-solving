using System;
using System.Collections.Generic;
using System.Text;

//https://codeforces.com/contest/1538/problem/A

namespace DotNetSolutions
{
    class Polycarp
    {
        public Polycarp()
        {
            int t;
            t = Convert.ToInt32(Console.In.ReadLine());
            List<int> output = new List<int>();
            for (int i = 0; i < t; i++)
            {
                int n;
                n = Convert.ToInt32(Console.In.ReadLine());

                string[] tokens = Console.ReadLine().Split();
                int[] numbers = Array.ConvertAll(tokens, int.Parse);

                output.Add(FindMinSteps(numbers));
            }

            foreach (var val in output)
            {
                Console.Out.WriteLine(val);
            }
        }

        private int FindMinSteps(int[] numbers)
        {
            int minSteps = 0;

            int minPos = -1, minNum = Int32.MaxValue;
            int maxPos = -1, maxNum = Int32.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minNum)
                {
                    minPos = i;
                    minNum = numbers[i];
                }

                if (numbers[i] > maxNum)
                {
                    maxPos = i;
                    maxNum = numbers[i];
                }
            }

            int leftSteps = minPos < maxPos ? minPos + 1: maxPos + 1;
            int rightSteps = minPos > maxPos ? numbers.Length - minPos : numbers.Length - maxPos;
            int gap = Math.Abs(minPos - maxPos);

            if (leftSteps < rightSteps)
            {
                if (gap < rightSteps)
                {
                    minSteps = leftSteps + gap;
                }
                else
                {
                    minSteps = leftSteps + rightSteps;
                }
            }
            else
            {
                if (gap < leftSteps)
                {
                    minSteps = rightSteps + gap;
                }
                else
                {
                    minSteps = leftSteps + rightSteps;
                }
            }
            //Console.WriteLine(minSteps);

            return minSteps;
        }
    }
}
