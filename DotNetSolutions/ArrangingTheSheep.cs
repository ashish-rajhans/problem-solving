using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetSolutions
{
    //https://codeforces.com/contest/1520/problem/E
    class ArrangingTheSheep
    {
        public ArrangingTheSheep()
        {
            int t;
            t = Convert.ToInt32(Console.In.ReadLine());
            List<long> output = new List<long>();
            for (int i = 0; i < t; i++)
            {
                int n;
                n = Convert.ToInt32(Console.In.ReadLine());

                string sheep = Console.ReadLine();

                output.Add(Arrange(sheep));
            }

            foreach (var val in output)
            {
                Console.Out.WriteLine(val);
            }
        }


        private long Arrange(string sheep)
        {
            long steps = 0;
            int totalSheep = sheep.Count(x => x == '*');

            if (totalSheep <= 1)
            {
                return 0;
            }

            int leftSheepCount = 0;
            int i = 0;
            for (; i < sheep.Length; i++)
            {
                if (sheep[i] == '*')
                {
                    ++leftSheepCount;
                }
                else if (leftSheepCount < totalSheep - leftSheepCount)
                {
                    steps += leftSheepCount;
                }
                else
                {
                    break;
                }
            }

            int rightSheepCount = 0;
            for (int j = sheep.Length - 1; j >= i; --j)
            {
                if (sheep[j] == '*')
                {
                    ++rightSheepCount;
                }
                else if (rightSheepCount <= totalSheep - rightSheepCount)
                {
                    steps += rightSheepCount;
                }
            }

            return steps;
        }
    }
}
