using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//https://codeforces.com/contest/1538/problem/B

namespace DotNetSolutions
{
    class PolycarpCandies
    {
        public PolycarpCandies()
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

                output.Add(FindMink(numbers));
            }

            foreach (var val in output)
            {
                Console.Out.WriteLine(val);
            }
        }

        private int FindMink(int[] numbers)
        {
            int n = numbers.Length;

            int sum = numbers.Sum();
            int remainder = sum % n;

            if (remainder != 0)
            {
                return -1;
            }

            int e = sum / n;

            return numbers.Where(num => num > e).Count();
        }
    }
}
