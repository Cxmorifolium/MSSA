/*
Given a string s, reverse only all the vowels in the string and return it.

The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.

Example 1:

Input: s = "IceCreAm"

Output: "AceCreIm"

Explanation:

The vowels in s are ['I', 'e', 'e', 'A']. On reversing the vowels, s becomes "AceCreIm".

*/
using System;
class Program
{
    static void Main(string[] args)
    {
        string s = "IceCream";
        Console.WriteLine($"{ReverseVowels(s)}");
    }

    static string ReverseVowels(string s) 
    {
        // Copied previous leetcode solution but added something new lol
        HashSet<char> vowels = new HashSet<char> 
        { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
        
        char [] v = s.ToCharArray();
        int left = 0;
        int right = v.Length -1;

        while (left < right)
        {
            //put condition to check for VOWELS only
            while (left < right && !vowels.Contains(v[left]))
            left++;

            while (left < right && !vowels.Contains(v[right]))
            right--;

            char temp = v[left];
            v[left] = v[right];
            v[right] = temp;

            left++;
            right--;
        }

        return new string(v);
        
    }

        // Dictionary is for key-value pairs only
        // List is linear search
        // Hash is good for fast look ups
}