using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace group04_FinalProject
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ddlLeetCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProblem = ddlLeetCode.SelectedValue;
            //display problem description and test case
            switch (selectedProblem)
            {
               

                case "Integer to Roman":
                    ProblemDescription.InnerText = "Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.Given an integer, convert it to a roman numeral.";
                    testCase.InnerText = "Test case: Input: dividend = 10, divisor = 2";
                    break;

                case "Basic Calculator":
                    ProblemDescription.InnerText = "Given a string s representing a valid expression, implement a basic calculator to evaluate it, and return the result of the evaluation. ";
                    testCase.InnerText = "s = 1 + 1";
                    break;

               // case "Candy":
                    //ProblemDescription.InnerText = "There are 'n' children standing in a line. Each child is assigned a rating value given in the integer array rating.You are giving candies to these children subjected to the following requirements:\r\n\r\nEach child must have at least one candy. Children with a higher rating get more candies than their neighbors.\r\nReturn the minimum number of candies you need to have to distribute the candies to the children.";
                    //testCase.InnerText = "Test case: Input: ratings=[1,0,2]";
                   // break;
                default:
                    break;
            }

        }

      
        protected void btnSolve_Click(object sender, EventArgs e)
        {
            string selectedProblem = ddlLeetCode.SelectedValue;
            //Invoke
            switch (selectedProblem)
            {
                case "Basic Calculator":
                    // Instantiate the calculator class
                    LeetcodeProblemBasicCalculator calcSolution = new LeetcodeProblemBasicCalculator();

                    // Example usage with a string that represents an arithmetic expression
                    string expression = "1 + 0 - 2"; // This string should represent your problem statement
                    int result = calcSolution.Calculate(expression);

                    // Update the inner text of a solution element with the result
                    solution.InnerText = "Basic Calculator Solution: " + result;
                    break;


                case "Integer to Roman":
                    leetcodeproblemIntegertoRoman intToRomSolution = new leetcodeproblemIntegertoRoman();
                    int number = 1994;  // Example integer. Replace with actual number as required.
                    string romanNumeral = intToRomSolution.IntToRoman(number);
                    solution.InnerText = "Integer to Roman Solution: " + romanNumeral;
                    break;



                default:
                    break;
            }
        }
    }

}