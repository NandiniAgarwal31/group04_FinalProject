/*
#Name:Manaal Ameer
#Email: ameerml@mail.uc.edu
#Assignment Title : Final Project
#Due Date: 04/23/2024
#Course: IS 3050
#Semester/Year: Spring 2024
#Brief Description: LeetCode Problem Climbing Stairs
#Citations: https://leetcode.com/problems/climbing-stairs/
#Anything else that's relevant
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace group04_FinalProject
{
    public class leetcodeproblemClimbingStairs
    {  
       /// <param name="n">The total number of steps to reach the top of the staircase.</param>
       
        public int ClimbStairs(int n)
        {
            if (n <= 1)
            {
                return 1; 
            }

            int previous = 1;  
            int current = 1;   
            int temporary;     

            for (int i = 2; i <= n; i++)
            {
                temporary = current;              
                current += previous;              
                previous = temporary;             
            }

            return current; 
        }
    }
}