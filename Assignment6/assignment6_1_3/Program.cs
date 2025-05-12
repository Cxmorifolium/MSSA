/*
Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
Note that you must do this in-place without making a copy of the array.

Example 1:

Input: nums = [0,1,0,3,12]
Output: [1,3,12,0,0]
Example 2:

Input: nums = [0]
Output: [0]

simple version is array.

*/

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = {0, 1, 0, 3, 12};
        MoveZeroes(nums);

        Console.WriteLine("Modified array:");
        foreach(int num in nums)
        {
            Console.Write(num + " ");
        }

    }

    // Via Array Swapping method:
    static void MoveZeroes(int[] nums)
    {
        int pointer = 0; 
        // Because of loop TC is O(n)
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {   
                //temp is now index 1
                int temp = nums[i];
                //pointer is now num[i]
                nums[i] = nums[pointer];
                //pointer is new temp
                nums[pointer] = temp;
                //continue forward
                pointer++;
            }
        }
        
    }


}