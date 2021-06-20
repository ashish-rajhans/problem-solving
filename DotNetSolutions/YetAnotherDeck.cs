using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetSolutions
{
    //https://codeforces.com/contest/1511/problem/C
    class YetAnotherDeck
    {
        public YetAnotherDeck()
        {
            int n, q;
            string[] tokens = Console.ReadLine().Split();

            List<string> output = new List<string>();
            string[] strCards = Console.ReadLine().Split();
            int[] cards = Array.ConvertAll(strCards, int.Parse);

            string[] strQueries = Console.ReadLine().Split();
            int[] queries = Array.ConvertAll(strQueries, int.Parse);

            output.Add(FindAnswers(cards, queries));

            foreach (var val in output)
            {
                Console.Out.WriteLine(val);
            }
        }

        private void rotate (ref int[] cards, int pos)
        {
            int first = cards[pos];
            for (int i = pos; i > 0; --i)
            {
                cards[i] = cards[i - 1];
            }
            cards[0] = first;
        }


        private string FindAnswers(int[] cards, int[] queries)
        {
            string output = "";

            for (int i = 0; i < queries.Length; i++)
            {
                int pos = Array.IndexOf(cards, queries[i]);
                output += (pos + 1).ToString() + " ";

                rotate(ref cards, pos);
            }

            return output;
        }

    }
}
