using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetSolutions
{
    //https://codeforces.com/contest/1511/problem/B
    class GCDLength
    {
        public GCDLength()
        {
            int t;
            t = Convert.ToInt32(Console.In.ReadLine());
            List<string> output = new List<string>();
            for (int i = 0; i < t; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                int[] numbers = Array.ConvertAll(tokens, int.Parse);

                output.Add(FindXY(numbers));
            }

            foreach (var val in output)
            {
                Console.Out.WriteLine(val);
            }
        }

        private string FindXY(int[] numbers)
        {
            int a = numbers[0];
            int b = numbers[1];
            int c = numbers[2];
            int x = 0, y = 0;

            if (a < b)
            {
                x = (int)Math.Pow(10, a - 1);
                if (c < a)
                {
                    y = (int)Math.Pow(10, b - 1) + 5 * (int)Math.Pow(10, c - 1);
                }
                else
                {
                    y = (int)Math.Pow(10, b - 1);
                }                
            }
            else
            {
                y = (int)Math.Pow(10, b - 1);
                if (c < b)
                {
                    x = (int)Math.Pow(10, a - 1) + 5 * (int)Math.Pow(10, c - 1);
                }
                else
                {
                    x = (int)Math.Pow(10, a - 1);
                }
            }

            string output = x.ToString() + " " + y.ToString();
            return output;
        }    
    }
}
