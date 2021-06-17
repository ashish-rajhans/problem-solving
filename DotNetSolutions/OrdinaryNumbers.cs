using System;
using System.Collections.Generic;
using System.Text;

//https://codeforces.com/contest/1520/problem/B
namespace DotNetSolutions
{
    class OrdinaryNumbers
    {
        public OrdinaryNumbers()
        {
            int t;
            t = Convert.ToInt32(Console.In.ReadLine());
            List<int> output = new List<int>();
            for (int i = 0; i < t; i++)
            {
                int n;
                n = Convert.ToInt32(Console.In.ReadLine());
                output.Add(countOrdinaryNumbers(n));
            }

            foreach (var val in output)
            {
                Console.Out.WriteLine(val);
            }
        }

        private int countOrdinaryNumbers(int n)
        {
            int count = 0;            

            string strNumber = n.ToString();
            int digits = strNumber.Length;
            int i = digits;
            while (i-- > 1)
            {
                count += 9;
            }

            count += int.Parse(strNumber[0].ToString()) - 1;

            string num = new string(strNumber[0], digits);
            if (n >= int.Parse(num))
            {
                ++count;
            }

            return count;
        }
    }
}
