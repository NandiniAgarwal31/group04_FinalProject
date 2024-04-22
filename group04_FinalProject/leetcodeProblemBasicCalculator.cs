/*
#Name:Mahika Gunjkar
#Email: gunjkamg@mail.uc.edu
#Assignment Title : Final Project
#Due Date: 04/23/2024
#Course: IS 3050
#Semester/Year: Spring 2024
#Brief Description: Given a string s representing a valid expression, implement a basic calculator to evaluate it, and return the result of the evaluation
#Citations: https://leetcode.com/problems/basic-calculator/description/
#Anything else that's relevant
*/



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
                   
                    stack.Push(result);
                    stack.Push(sign);
                    
                    result = 0;
                    sign = 1;
                    i++;
                }
                else if (c == ')')
                {
                    
                    result *= stack.Pop();
                   
                    result += stack.Pop();
                    i++;
                }
                else if (c == ' ')
                {
                   
                    i++;
                }
                else
                {
                   
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
