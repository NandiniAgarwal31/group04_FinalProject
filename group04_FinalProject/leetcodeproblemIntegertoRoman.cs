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
