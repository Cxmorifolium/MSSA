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
    // // Example Execution
    // static void Main(string[] args) 
    // {
    //     int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
    //     Console.WriteLine("Enter a number to search for: ");
    //     int searchVal = Convert.ToInt32(Console.ReadLine());
        
    //     int index = ItemSearch(arr, searchVal);
        
    //     if (index != -1)
    //         {
    //             Console.WriteLine($"Value {searchVal} found at index {index}");
    //         }
    //         else
    //         {
    //             Console.WriteLine($"Value {searchVal} not found.");
    //         }

    // }

    // Said function i totally stole even though I really wanted to use the built in function
    static int ItemSearch(int[] arr, int val)
    {
        for(int i = 0; i < arr.Length; i++)
            if (arr[i] == val)
                return i;
        return -1;
    }
    
}

// Built in method
// int index = Array.IndexOf(arr, searchVal);