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
               

                case "Integer to Roman Problem":
                    ProblemDescription.InnerText = "Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.Given an integer, convert it to a roman numeral.";
                    testCase.InnerText = "Test case: Input: dividend = 10, divisor = 2";
                    break;

                case "ZigZag":
                    ProblemDescription.InnerText = "The string 'PAYPALISHIRING' is written in a zigzag pattern on a given number of rows, and then read line by line:'PAHNAPLSIIGYIR' ";
                    testCase.InnerText = "N/A";
                    break;

                case "Candy":
                    ProblemDescription.InnerText = "There are 'n' children standing in a line. Each child is assigned a rating value given in the integer array rating.You are giving candies to these children subjected to the following requirements:\r\n\r\nEach child must have at least one candy. Children with a higher rating get more candies than their neighbors.\r\nReturn the minimum number of candies you need to have to distribute the candies to the children.";
                    testCase.InnerText = "Test case: Input: ratings=[1,0,2]";
                    break;
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
                default:
                    break;
            }
        }
    }
}