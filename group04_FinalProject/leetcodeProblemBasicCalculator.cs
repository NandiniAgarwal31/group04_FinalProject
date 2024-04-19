using System;
using System.Collections.Generic;
using System.Text;

namespace group04_FinalProject
{
    public class LeetcodeProblemBasicCalculator
    {
        public int Calculate(string s)
        {
            int result = 0;
            int i = 0;
            Stack<int> stack = new Stack<int>();
            int sign = 1;

            while (i < s.Length)
            {
                char c = s[i];
                if (c == '+')
                {
                    sign = 1;
                    i++;
                }
                else if (c == '-')
                {
                    sign = -1;
                    i++;
                }
                else if (c == '(')
                {
                    // Push the result and the sign onto the stack
                    stack.Push(result);
                    stack.Push(sign);
                    // Reset the result and sign for the new sub-expression
                    result = 0;
                    sign = 1;
                    i++;
                }
                else if (c == ')')
                {
                    // Pop the sign and apply it to the result
                    result *= stack.Pop();
                    // Add the result to the next operand on the top of the stack
                    result += stack.Pop();
                    i++;
                }
                else if (c == ' ')
                {
                    // Skip spaces
                    i++;
                }
                else
                {
                    // If it's a digit, build the number and then add it to the result
                    int num = 0;
                    while (i < s.Length && char.IsDigit(s[i]))
                    {
                        num = num * 10 + (s[i] - '0');
                        i++;
                    }
                    result += sign * num;
                }
            }

            return result;
        }
    }
}
