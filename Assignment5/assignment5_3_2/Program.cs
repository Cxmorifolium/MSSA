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
        // Added test case cus I forgot
        int steps1 = 2;
        int result1 = ClimbStairs(steps1);
        Console.WriteLine($"Ways to climb {steps1} steps: {result1}");
    }
    
    static int ClimbStairs(int n)
    {
        // Oop gotta check for this first
        if (n <= 1) return 1;

        // Fibonacci-like series where F(1) = 1 and F(2) = 2
        int[] series = new int[n + 1];
        series[0] = 1; // base condition: starting at the bottom
        series[1] = 1; // 1 way to climb to the first step (1 step)

        for (int i = 2; i <= n; i++)
        {
            series[i] = series[i - 1] + series[i - 2]; // ways to reach the current step
        }
        
        return series[n];
    }


}