/*
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

Input: nums = [2,7,11,15], target = 9

Output: [0,1]
*/

using System;

class Program {
    static void Main(string[] args)
    {
        int[] nums = { 2, 11, 7, 15 };
        int target = 18;

        int[] result = TwoSum(nums, target);

        if (result.Length > 0)
        {
            Console.WriteLine($"Indices: {result[0]}, {result[1]}");
        }
        else
        {
            Console.WriteLine("No solution found.");
        }
    }
    
    static int[] TwoSum(int[] nums, int target) 
    {
        /* int TwoSum recieves two array nums and target as parameter 
        Method: Use dictionary (kekeke learning something new)
            Key = number itself, Value = index in array
        */
        Dictionary<int, int> map = new Dictionary<int, int>();
        
        // Loop through each element in the nums array
        for (int i = 0; i < nums.Length; i++) 
        {
            // Calculate the number needed to reach target
            int complementaryNumber = target - nums[i];
            // If number exist then returns index of complementary number and current index
            if (map.ContainsKey(complementaryNumber)) {
                return new int[] {map[complementaryNumber], i};
            }

            // if not found, add current number and its index to dictionary to check later
            map[nums[i]]= i;
        }

        // return empty if no solution found
        return new int[] {};       
    }

}