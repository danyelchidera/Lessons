using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.Algorithms
{
    public class Brackets
    {
        public static bool IsBracketsValid(string str)
        {
            System.Collections.Generic.Stack<char> stack = new System.Collections.Generic.Stack<char>();

            foreach (var i in str)
            {
                switch (i)
                {
                    case '{':
                        stack.Push(i);
                        break;
                    case '(':
                        stack.Push(i);
                        break;
                    case '<':
                        stack.Push(i);
                        break;
                    case '[':
                        stack.Push(i);
                        break;
                    case '}':
                        {
                            if (stack.Pop() != '{')
                            {
                                return false;
                            }
                        }
                        break;
                    case ')':
                        {
                            if (stack.Pop() != '(')
                            {
                                return false;
                                

                            }
                            break;
                        }
                    case ']':
                        {
                            if (stack.Pop() != '[')
                            {
                                return false;

                            }
                            break;
                        }
                    case '>':
                        {
                            if (stack.Pop() != '<')
                            {
                                return false;

                            }
                            break;
                        }
                }
            }

            return stack.Count == 0;
        }
    }
}
