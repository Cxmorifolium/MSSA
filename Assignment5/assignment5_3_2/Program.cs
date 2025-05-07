/*
You are climbing a staircase. It takes n steps to reach the top.
Each time you can either climb 1 or 2 steps. 
In how many distinct ways can you climb to the top?

Example 1:
Input: n = 2
Output: 2

Explanation: There are two ways to climb to the top.
1. 1 step + 1 step
2. 2 steps
*/

using System;

class Program 
{
    static void Main(string[] args) 
    {

    }
    
    static int ClimbStairs(int n)
    {
        // It's fibonacci in which F(1) = 1 and F(2) = 2 thus rewriting from example problem:
        int[] series = new int[n+1];
        series[0] = 1; // base condition: starting at the bottom it's 1
        series[1] = 1; // going up: 1 step
        
        for (int i = 2; i <= n; i++)
        {   // series[i-1] = take 1 step; series[i-2] = take 2 step
            series[i] = series[i-1] + series[i-2];
        }
        return series[n];

        if (n <= 1) return 1;
    }

}