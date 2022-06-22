using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.Algorithms
{
    public class HighestRepeatingChar
    {
        static string GetHighesetRepeatingChar(string str)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            char maxKey = default(char);
            int maxCount = 0;

            foreach (char c in str)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }

            foreach (var c in dict.Keys)
            {
                if (maxCount == dict[c])
                {
                    if (c < maxKey)
                    {
                        maxKey = c;
                    }
                }
                else if (dict[c] > maxCount)
                {
                    maxCount = dict[c];
                    maxKey = c;
                }
            }
            return $"{maxKey} {maxCount}";
        }

    }
}
