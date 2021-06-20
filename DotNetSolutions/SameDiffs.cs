using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetSolutions
{
    //https://codeforces.com/contest/1520/problem/D
    class SameDiffs
    {
        private int[] populate()
        {
            int[] numbers = new int [200000];
            for (int i = 0; i < 200000; i++)
            {
                numbers[i] = i;
            }
            return numbers;
        }
        public SameDiffs()
        {
            int t;
            t = Convert.ToInt32(Console.In.ReadLine());
            List<long> output = new List<long>();
            for (int i = 0; i < t; i++)
            {
                int n;
                n = Convert.ToInt32(Console.In.ReadLine());

                //string[] tokens = Console.ReadLine().Split();
                //int[] numbers = Array.ConvertAll(tokens, int.Parse);
                int[] numbers = populate();

                output.Add(findSameDiffs(numbers));
            }

            foreach (var val in output)
            {
                Console.Out.WriteLine(val);
            }
        }

        private long findSameDiffs(int[] numbers)
        {
            long pairsCount = 0;

            Dictionary<int, long> aiiDiffToi = new Dictionary<int, long>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (aiiDiffToi.ContainsKey(numbers[i] - i))
                {
                    ++aiiDiffToi[numbers[i] - i];
                }
                else
                {
                    aiiDiffToi[numbers[i] - i] = 1;
                }
            }

            foreach (var diff in aiiDiffToi)
            {
                if(diff.Value > 1)
                {
                    pairsCount += (diff.Value * (diff.Value - 1) / 2);
                }
            }            

            return pairsCount;
        }
    }
}
