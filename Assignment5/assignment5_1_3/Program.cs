/*
3. Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
Example 1:
Input: nums = [1,2,3,1]
Output: true
Example 2:
Input: nums = [1,2,3,4]
Output: false
Example 3:
Input: nums = [1,1,1,3,3,4,3,2,4,2]
Output: true
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] num = { 1, 2, 3, 3,};
        Console.WriteLine($"num[1,2,3,3]: {UniqueValue(num)}");
    }

    // // This method checks elements against each other to see if they match
    // static bool UniqueValue (int[] num)
    // {
    //     int n = num.Length;
    //     for (int i = 0; i < n-1; i++)
    //     {
    //         for (int j = i + 1; j < n; j++)
    //         {
    //             if (num[1] == num[j])
    //             {
    //                 return true;
    //             }
    //         }
    //     }

    //     return false;

    // }

    static bool UniqueValue(int[] num)
{
    // Create dictionary 
    Dictionary<int, bool> numbers = new Dictionary<int, bool>();

    // Loop through the array
    for (int i = 0; i < num.Length; i++)
    {
        if (numbers.ContainsKey(num[i])) // Check if number have been seen
        {
            return true; // Return true if duplicate found
        }
        else
        {
            numbers[num[i]] = true; // Mark number as seen if we haven't seen it before
        }
    }

    return false; // No duplicates found
    }

}