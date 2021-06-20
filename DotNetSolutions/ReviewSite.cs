using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetSolutions
{
    //https://codeforces.com/contest/1511/problem/A
    class ReviewSite
    {
        public ReviewSite()
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

                output.Add(FindUpvotes(numbers));
            }

            foreach (var val in output)
            {
                Console.Out.WriteLine(val);
            }
        }

        private int FindUpvotes(int [] numbers)
        {
            int upvotes = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 1 || numbers[i] == 3)
                {
                    ++upvotes;
                }
            }

            return upvotes;
        }
    }
}
