// Given a string, write a method that checks if it is a palindrome (is read the same backward as forward). 
// Assume that string may consist only of lower-case letters.

using System;

class Program 
{
    static void Main(string[] args) 
    {
        string word = "racecar"; 
        
        bool isPalindrome = IsPalindrome(word);
        
        if (isPalindrome)
        {
            Console.WriteLine($"{word} is a palindrome!");
        }
        else
        {
            Console.WriteLine($"{word} is NOT a palindrome.");
        }
    }

    static bool IsPalindrome(string input)
    {
        int length = input.Length;

        for (int i = 0; i < length / 2; i++)
        {
            int j = length - 1 - i; 

            if (input[i] != input[j])
            {
                return false;
            }
        }

        return true;
    }
}
