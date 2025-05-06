/*
Write a program in C# Sharp to check whether a given string is Palindrome or not using recursion.
Test Data :
Input a string : RADAR
Expected Output :
The string is Palindrome.
*/

using System;

class Program 
{
    static void Main(string[] args) 
    {
        string str = "rotator";

        bool isPalindrome = PalindromeRecursion(str);

        if(isPalindrome)
        {
            Console.Write($"{str}: The string is a palindrome");
        }
        else
        {
            Console.WriteLine($"{str}: The string is not a palindrome");
        }

    }

    // Base case: if str has 0 or 1 character = palindrome
    // Implementation does not check for spaces or normalizing cases
    static bool PalindromeRecursion (string input)
    {
        // Base case:
        if (input.Length <=1) 
        {
            return true;
        }

        // Check if first and last character are the same
        if (input[0] != input[input.Length - 1]) 
        {
            return false;
        }
    
        // Otherwise check the in betweens
        return PalindromeRecursion(input.Substring(1, input.Length-2));
        // Index 1 and 2nd to last index check, continuing until condition is met
        
    }
}