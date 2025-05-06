/*
1. Given a string s consisting of words and spaces, return the length of the last word in the string. A word is a maximal substring consisting of non-space characters only.

Example 1:

Input: s = "Hello World"
Output: 5
Explanation: The last word is "World" with length 5.
Example 2:

Input: s = " fly me to the moon "
Output: 4
Explanation: The last word is "moon" with length 4.

Pseudo:

Using list, space seperated split to identify words
List has a function Last() and finding length using .length
*/

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args) 
    {
        string word = "The Cow Jumped Over The Moon";
        LengthOfLastWord(word);
    }

    static void LengthOfLastWord(string s)
    {
        var list = new List<string>(s.Split(' ', StringSplitOptions.RemoveEmptyEntries)); // Using list and splitting the words by space
        Console.WriteLine($"Last word: \"{list.Last()}\""); //LINQ Last() from list
        Console.WriteLine($"Length: {list.Last().Length}"); //LINQ again
    }
}

