/*Given two strings s and t, return true if t is an of s, and false otherwise.
Example 1:

Input: s = "anagram", t = "nagaram"

Output: true*/

using System;

class Program
{
    static void Main(string[] args)
    {
        string s = "anagram";
        string t = "nagaram";

        bool result = IsAnagram(s, t);
        Console.WriteLine($"{s}, {t}, {result}");

    }

    // Dictionary method
    static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        Dictionary<char, int> charCount = new Dictionary<char, int>();

        // Count the number of each letter in string s
        foreach (char c in s)
        {
            if (charCount.ContainsKey(c))
                charCount[c]++;
            else
                charCount[c] = 1;
        }

        // Count the numnber of each letter in string t and compare
        foreach (char c in t)
        {
            if (!charCount.ContainsKey(c))
                return false;
            charCount[c]--;
            if (charCount[c] < 0)
                return false;
        }
        return true;
    }
}
