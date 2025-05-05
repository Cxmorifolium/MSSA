/*
1. Given an integer x, return true if x is a palindrome, and false otherwise.
Example 1:
Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.
Example 2:
Input: x = -121
Output: false
*/

using System;

class Program 
{
    static void Main(string[] args) 
    {
        int num = -121;
        int num2 = 121;
        int num3 = 0;
        Console.WriteLine($"Num {num}: {IsIntPalindrome(num)};\nNum {num2}: {IsIntPalindrome(num2)}\nNum {num3}: {IsIntPalindrome(num3)}");

    }
    
    // Method to check true or false
    static bool IsIntPalindrome (int num)
    {
        int forward = num;
        int backward = 0;

        while (num > 0)
        {
            int number = num % 10; // Get the last digit
            backward = backward * 10 + number; // Append to the right
            num = num / 10; // Remove last digit from original number
        }

        return forward == backward;
    }
}