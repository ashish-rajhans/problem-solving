using System;
using System.Collections.Generic;
using System.Text;

//https://codeforces.com/contest/1538/problem/C

namespace DotNetSolutions
{
    class NumberOfPairs
    {
        public NumberOfPairs()
        {
            int t;
            t = Convert.ToInt32(Console.In.ReadLine());
            List<int> output = new List<int>();
            for (int i = 0; i < t; i++)
            {
                int n, l, r;

                string[] tokens = Console.ReadLine().Split();
                int[] numbers = Array.ConvertAll(tokens, int.Parse);

                n = numbers[0];
                l = numbers[1];
                r = numbers[2];

                tokens = Console.ReadLine().Split();
                numbers = Array.ConvertAll(tokens, int.Parse);

                output.Add(FindNoOfPairs(numbers, n, l, r));
            }

            foreach (var val in output)
            {
                Console.Out.WriteLine(val);
            }
        }

        //Last element smaller than val in logn time
        private int GetLowerBound(int[] numbers, int val)
        {
            int l = 0, r = numbers.Length - 1;

            while (l < r)
            {
                int mid = (l + r) / 2;

                if (numbers[mid] == val)
                {
                    return mid;
                }

                if (numbers[mid] < val && numbers[mid + 1] > val)
                {
                    return mid;
                }

                if (numbers[mid] < val)
                {
                    if (l == mid)
                    {
                        break;
                    }
                    l = mid;
                }
                else
                {
                    r = mid;
                }
            }

            return l;
        }

        //First element greater than val in logn time
        private int GetUpperBound(int [] numbers, int val)
        {
            int l = 0, r = numbers.Length - 1;

            while (l < r)
            {
                int mid = (l + r) / 2;

                if (numbers[mid] == val)
                {
                    return mid + 1;
                }

                if (numbers[mid] < val && numbers[mid + 1] > val)
                {
                    return mid + 1;
                }

                if (numbers[mid] < val)
                {
                    if (l == mid)
                    {
                        break;
                    }
                    l = mid;
                }
                else
                {
                    r = mid;
                }
            }

            return r;
        }

        private int FindNoOfPairs(int[] numbers, int n, int l, int r)
        {
            int pairs = 0;
            Array.Sort(numbers);
            for (int left = 0; left < n; left++)
            {
                int firstRight = left + 1;
                if (numbers[left] > r)
                {
                    continue;
                }
                int ub = GetUpperBound(numbers, r - numbers[left]);
                int lb = GetLowerBound(numbers, l - numbers[left]);
                pairs += ub - lb;
            }
            return pairs / 2;
        }
    }
}
