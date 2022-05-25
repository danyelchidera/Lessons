using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.Algorithms
{
    public class FirstNoneRepeatedChar
    {
        public char FirstNoneRepeated(string str)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for(int i = 0; i < str.Length; i++)
            {
                if(! dict.ContainsKey(str[i]))
                {
                    dict.Add(str[i], 1);
                }
                else
                {
                    dict[str[i]]++;
                }
            }

            foreach(char c in dict.Keys)
            {
                if(dict[c] == 1)
                {
                    return c;
                }
            }

            return ' ';
        }
    }
}