/*
Write a function that reverses a string. The input string is given as an array of characters s.

You must do this by modifying the input array in-place. (Problem 344 in leetcode)

Example 1:

Input: s = ["h","e","l","l","o"]

Output: ["o","l","l","e","h"]

Example 2:

Input: s = ["H","a","n","n","a","h"]

Output: ["h","a","n","n","a","H"]
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        char[] arr = { 'H', 'E', 'L', 'M', 'N', 'P' };
        ReverseArray(arr);

        foreach (char c in arr)
        {
            Console.Write(c + " ");
        }
    }

    static void ReverseArray(char[] arr)
    {
        int left = 0; //index 0!
        int right = arr.Length - 1; // last index!

        while (left < right)
        {
            char temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;

            left++;
            right--;
        }
    }
}
