/*You are given two strings word1 and word2. 
Merge the strings by adding letters in alternating order, starting with word1. 
If a string is longer than the other, append the additional letters onto the end of the merged string.
Return the merged string.

Example 1:
Input: word1 = "abc", word2 = "pqr"
Output: "apbqcr"
Explanation: The merged string will be merged as so:
word1: a b c
word2: p q r
merged: a p b q c r

Example 2:
Input: word1 = "ab", word2 = "pqrs"
Output: "apbqrs"
Explanation: Notice that as word2 is longer, "rs" is appended to the end.
word1: a b
word2: p q r s
merged: a p b q r s 

Hint 1: Use two pointers, one pointer for each string. 
Alternately choose the character from each pointer, and move the pointer upwards.*/

using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    { 
        // tested on leetcode
    }

    // StringBuilder works here because it's mutable and efficient
    // TC: O(n), but not efficient according to leetcode
    static void string MergeAlternately(string word1, string word2)
    {
        StringBuilder mergeWords = new StringBuilder();
        int i = 0, j = 0;

        while (i < word1.Length || j < word2.Length)
        {
            if (i < word1.Length)
                mergeWords.Append(word1[i++]);
            if (j < word2.Length)
                mergeWords.Append(word2[j++]);
        }
        return mergeWords.ToString();
    }

    // Found Soln that's more efficient
    // static void string MergeAlternately(string word1, string word2) {
    //     StringBuilder res = new StringBuilder();
    //     int i = 0, j = 0;
    //     while (i < word1.Length && j < word2.Length) {
    //         res.Append(word1[i]).Append(word2[j]);
    //         i++;
    //         j++;
    //     }

    //     while (i < word1.Length) {
    //         res.Append(word1[i]);
    //         i++;
    //     }

    //     while (j < word2.Length) {
    //         res.Append(word2[j]);
    //         j++;
    //     }

    //     return res.ToString();
    // }
}