using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.Algorithms
{
    public class Brackets
    {
        public bool IsBracketsValid(string str)
        {
            Stack<char> stack = new Stack<char>();

            var isValid = true;
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

            return true;
        }
    }
}
