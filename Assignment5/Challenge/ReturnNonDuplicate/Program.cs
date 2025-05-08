/*
Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.

Example 1:
Input: nums = [2,2,1]
Output: 1

Example 2:
Input: nums = [4,1,2,1,2]
Output: 4

Example 3:
Input: nums = [1]
Output: 1

mentioned: dict/hash/list
*/

using System;

class Program{
    static void Main(string[] args)
    {
        int[] nums = { 10,2,3,2,4,5,1 };
        Console.WriteLine($"Array:[10,2,3,2,4,5,1]; {ReturnNonDuplicate(nums)}");

    }

    static int ReturnNonDuplicate(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int count = 0; // Counter

            for (int j = 0; j < array.Length; j++)
            {
                if (array[i] == array[j]) //if elements are the same
                {
                    count++; // add to counter
                }
            }

            if (count == 1) //if an element count is only 1
            {
                return array[i]; // return that value in that element
            }
        }

        return -1; // if no unique number is found
    }


    // The cheater method bitwise XOR ^=
    // static int ReturnNonDuplicate(int[] array)
    // {
    //     int result = 0;
    //     foreach (int num in array)
    //     {
    //         result ^= num;
    //     }
    //     return result;
    // }

}