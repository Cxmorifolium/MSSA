/* 
Write a program in C# Sharp to create a function to input a string and count number of spaces are in the string.
Test Data :
Please input a string : This is a test string.
Expected Output :
"This is a test string." contains 4 spaces
*/

using System;

class Program {
    static void Main(string[] args) 
    {
        
        Console.Write("Please input a string: ");
        string input = Console.ReadLine() ?? "";

        int spaceCount = CountSpaces(input);

        Console.WriteLine($"\"{input}\" contains {spaceCount} spaces.");
    }

    static int CountSpaces(string input) 
    {
        int count = 0;
        foreach (char c in input)
        {
            if (c == ' ') 
            {
                count++;
            }
        }
        
        return count;
    }

}