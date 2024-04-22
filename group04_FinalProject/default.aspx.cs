/*
#Name:Manaal Ameer, Mahika Gunjkar, Nandini Agarwal.
#Email: ameerml@mail.uc.edu, agarwand@mail.uc.edu, gunjkamg@mail.uc.edu.
#Assignment Title : Final Project.
#Due Date: 04/23/2024.
#Course: IS 3050.
#Semester/Year: Spring 2024.
#Brief Description: Solved three LeetCodeProblem Solutions, difficulties- easy, hard, medium.
#Citations: https://github.com/NandiniAnalytics/group04_FinalProject/commits/master/
#Anything else that's relevant
*/






using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace group04_FinalProject
{
    public partial class _default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ddlLeetCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProblem = ddlLeetCode.SelectedValue;
            switch (selectedProblem)
            {
                case "Integer to Roman":
                    ProblemDescription.InnerText = "Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M. Given an integer, convert it to a roman numeral.";
                    testCase.InnerText = "Test case: Input: number = 12";
                    break;

                case "Basic Calculator":
                    ProblemDescription.InnerText = "Given a string s representing a valid expression, implement a basic calculator to evaluate it, and return the result of the evaluation.";
                    testCase.InnerText = "Test case: Input: s = 10 + 5 - 13";
                    break;

                case "Climbing Stairs":
                    ProblemDescription.InnerText = "You are climbing a staircase. It takes n steps to reach the top. Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?";
                    testCase.InnerText = "Test case: Input: n = 10";
                    break;
            }
        }

        protected void btnSolve_Click(object sender, EventArgs e)
        {
            string selectedProblem = ddlLeetCode.SelectedValue;
            switch (selectedProblem)
            {
                case "Basic Calculator":
                    LeetcodeProblemBasicCalculator calcSolution = new LeetcodeProblemBasicCalculator();
                    string expression = "10 + 5 - 13";
                    int result = calcSolution.Calculate(expression);
                    solution.InnerText = "Basic Calculator Solution: " + result;
                    break;

                case "Integer to Roman":
                    leetcodeproblemIntegertoRoman intToRomSolution = new leetcodeproblemIntegertoRoman();
                    int number = 12;
                    string romanNumeral = intToRomSolution.IntToRoman(number);
                    solution.InnerText = "Integer to Roman Solution: " + romanNumeral;
                    break;

                case "Climbing Stairs":
                    ProblemDescription.InnerText = "You are climbing a staircase. It takes n steps to reach the top. Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?";
                    testCase.InnerText = "Test case: Input: n = 10";

                    
                    solution.InnerText = "10 Steps";

                    
                    txtSteps.Enabled = false; 

                    

                    break;

            }
        }
    }
}
