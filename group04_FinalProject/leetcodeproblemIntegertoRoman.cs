/*
#Name:Nandini Agarwal
#Email: agarwand@mail.uc.edu
#Assignment Title : Final Project
#Due Date: 04/23/2024
#Course: IS 3050
#Semester/Year: Spring 2024
#Brief Description: Leetcode problem integer to roman, Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M. Given an integer, convert it to a roman numeral.
#Citations: https://leetcode.com/problems/integer-to-roman/description/
#Anything else that's relevant
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace group04_FinalProject
{
    public class leetcodeproblemIntegertoRoman
    {
        public string IntToRoman(int num)
        {
            
            string[] symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            string romanNumeral = ""; 

            
            for (int i = 0; i < values.Length; i++)
            {
                
                while (num >= values[i])
                {
                    
                    romanNumeral += symbols[i];

                    
                    num -= values[i];
                }
            }

            return romanNumeral;
        }
    }
}
