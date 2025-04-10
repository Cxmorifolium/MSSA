/* palindrome LeetCode125 A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and 
removing all non-alphanumeric characters,it reads the same forward and backward. 

Requirement input uniformity. could write method to clean before processing?
No actual function for palindrome -> create one as a method -> combine preprocessing + palindrome ? */

using System;

class Program {
    static void Main(string[] args) {
        string s = "A man, a plan, a canal: Panama"; // From LeetCode

        if (IsPalindrome(s)) // Use the correct variable name and method name
        {
            Console.WriteLine("This is a palindrome.");
        }
        else
        {
            Console.WriteLine("This is not a palindrome.");
        }
    }   

        /* Create method for palindrome + preprocessing all at once
        Logic for preprocessing: check string if numbers or letter. 
        if letter lowercase it, if number remove it, if there's a space, remove it.
        For palindrome use reverse method and check against original array 
        
        https://learn.microsoft.com/en-us/dotnet/api/system.string.tolower?view=net-9.0
        after a rabbit hole: https://learn.microsoft.com/en-us/dotnet/api/system.char.isletterordigit?view=net-9.0
        */

    static bool IsPalindrome(string sS) {
            var cleanString = new string(sS.Where(char.IsLetterOrDigit).Select(char.ToLower).ToArray()); //BLESS INTELLISENSE

            // Reverse the cleaned string
            var reverseString = new string(cleanString.Reverse().ToArray());

            return cleanString == reverseString;
        }
    }


// one brain cell is tryna revive the other