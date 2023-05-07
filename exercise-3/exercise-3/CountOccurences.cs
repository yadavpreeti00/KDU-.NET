using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_3
{
    internal class CountOccurences
    {
            public void GetOccurencesCount()
            {
                Console.Write("Enter a string: ");
                string input = Console.ReadLine();

                Dictionary<char, int> charCounts = new Dictionary<char, int>();

                foreach (char c in input)
                {
                    if (charCounts.ContainsKey(c))
                    {
                        charCounts[c]++;
                    }
                    else
                    {
                        charCounts.Add(c, 1);
                    }
                }

                foreach (KeyValuePair<char, int> pair in charCounts)
                {
                    Console.WriteLine(pair.Key + ": " + pair.Value);
                }
            }
    }
}

