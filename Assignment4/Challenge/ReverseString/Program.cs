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
        char[] arr = { 'H', 'E', 'L', 'L', 'O' };
        ReverseArray(arr);

        foreach (char c in arr)
        {
            Console.Write(c + " ");
        }
    }
    
    // Two pointer
    static void ReverseArray(char[] arr)
    {
        int left = 0; // Index 0!
        int right = arr.Length - 1; // Last index!

        while (left < right)
        {
            char temp = arr[left]; // Temp array to store
            arr[left] = arr[right]; // Left gets copied to right
            arr[right] = temp; // Left is now temp stored in right
            
            // Loop continues until pointers are equal, moving outward to center

            left++; // Move one step to right
            right--; // Move one step to left
        }
    }

    // // One pointer
    // static char[] ReverseArray(char[] s)
    // {
    //     char temp;
    //     for (int i = 0; i < s.Length / 2; i++)
    //     {
    //         temp = s[i];
    //         s[i] = s[s.Length - 1 - i];
    //         s[s.Length - 1 - i] = temp;
    //     }
    //     return s;
    // }

}
