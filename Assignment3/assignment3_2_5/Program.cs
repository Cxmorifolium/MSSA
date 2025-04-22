/*
Create a function that finds the index of a given item in the array
Examples
Search([1, 5, 3], 5) ➞ 1
Search([9, 8, 3], 3) ➞ 2
Search([1, 2, 3], 4) ➞ -1
Notes
If the item is not present, return -1.
*/

using System;

class Program {
    
    static void Main(string[] args) 
    {
        // Test Case Example
        Console.WriteLine(Search(new int[] { 1, 5, 3 }, 5));
        Console.WriteLine(Search(new int[] { 9, 8, 3 }, 3));
        Console.WriteLine(Search(new int[] { 1, 2, 3 }, 4)); 

        // Said function I totally stole even though I really wanted to use the built in function
        static int Search(int[] arr, int val)
        {
            for(int i = 0; i < arr.Length; i++)
                if (arr[i] == val)
                    return i;
            return -1;
        }
    
    }
}