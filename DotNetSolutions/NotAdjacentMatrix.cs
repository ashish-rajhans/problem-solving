using System;
using System.Collections.Generic;
using System.Text;

//https://codeforces.com/contest/1520/problem/C
namespace DotNetSolutions
{
    class NotAdjacentMatrix
    {
        public NotAdjacentMatrix()
        {
            int t;
            t = Convert.ToInt32(Console.In.ReadLine());
            List<string> output = new List<string>();
            for (int i = 0; i < t; i++)
            {
                int n;
                n = Convert.ToInt32(Console.In.ReadLine());
                output.AddRange(getNonAdjacentMatrix(n));
            }

            foreach (var val in output)
            {
                Console.Out.WriteLine(val);
            }
        }

        List<string> getNonAdjacentMatrix(int n)
        {
            List<string> output = new List<string>();

            if (n == 1)
            {
                output.Add("1");
                return output;
            }

            if (n == 2)
            {
                output.Add("-1");
                return output;
            }

            int currentNum = 1;
            for (int i = 0; i < n; i++)
            {
                string row = "";
                for (int j = 0; j < n; j++)
                {
                    row += currentNum + " ";
                    currentNum += 2;
                    if (currentNum > n * n)
                    {
                        currentNum = 2;
                    }
                }
                output.Add(row);
            }

            return output;
        }
    }
}
