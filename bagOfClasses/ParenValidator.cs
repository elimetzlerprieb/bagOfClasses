using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bagOfClasses
{
    public static class ParenValidator
    {
        public static bool isValid(string input)
        {
            Stack<char> stack = new Stack<char>();

            int countL = 0;
            int countR = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];

                // If any character isn't a left or right paren then the string is not valid 
                if (!(current == '(' || current == ')'))
                {
                    return false;
                }

                if (current == '(')
                {
                    countL += 1;
                }
                else if (current == ')')
                {
                    countR += 1;
                }

                // If there are ever more right parens than left parens then the string is not valid 
                if (countR > countL)
                {
                    return false;
                }

                if (stack.Count() == 0)
                {
                    if (current == ')')
                    {
                        return false;
                    }
                    else
                    {
                        stack.Push(current);
                    }
                }
                else
                {
                    char last = stack.Peek();

                    // we can do this check because if any other character exists we've already return an invalid response
                    if (last == '(')
                    {
                        if (current == ')')
                        {
                            stack.Pop();
                        }
                        else if (current == '(')
                        {
                            stack.Push(current);
                        }
                    }
                    else if (last == ')')
                    {
                        return false;
                    }
                }
            }

            if (stack.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
