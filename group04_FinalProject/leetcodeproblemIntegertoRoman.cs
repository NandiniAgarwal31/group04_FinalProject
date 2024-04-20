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



            // Arrays for Roman numeral symbols and their corresponding values

            string[] symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };



            StringBuilder romanNumeral = new StringBuilder();

            // Iterate through the values array

            for (int i = 0; i < values.Length; i++)

            {

                // While the given number is greater than or equal to the current value

                while (num >= values[i])

                {

                    // Append the corresponding symbol to the result

                    romanNumeral.Append(symbols[i]);

                    // Subtract the value from the given number

                    num -= values[i];

                }

            }



            return romanNumeral.ToString();
        }
    }