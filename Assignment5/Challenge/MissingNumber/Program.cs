﻿/*
Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that is missing from the array.
Example 1:

Input: nums = [3,0,1]
Output: 2
Explanation: n = 3 since there are 3 numbers, so all numbers are in the range [0,3]. 2 is the missing number in the range since it does not appear in nums.

Example 2:
Input: nums = [0,1]
Output: 2

HashSet --> add numbers ---> compare them ---> print out missing number
just kidding i don't understand it
*/

using System;

class Program
{
    static void Main(string[] args) 
    {
        int[] array = { 0, 1, 2, 3, 5, 6 };
        int missing = MissingNumber(array);
        Console.WriteLine("Missing number from 0,1,2,3,5,6: " + missing);
    }

    static int MissingNumber(int[] num)
    {
        //similar to previous problem O(nlogn) due to sort
        Array.Sort(num);
        for(int i = 0; i < num.Length; i++)
        {
            if( i != num[i]) return i; //if no matching value, return the value that is missng
        }
        return num.Length; // the missing index is the number
    }
    // Note this method does not hand multiple missing numbers.
}