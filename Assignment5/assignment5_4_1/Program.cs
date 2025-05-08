/*
Write a program in C# Sharp to display the individual digits of a given number using recursion.
Test Data :
Input any number : 1234
Expected Output :
The digits in the number 1234 are : 1 2 3 4
*/

using System;

class Program 
{
    static void Main(string[] args)
    {
        string number = PrintNumbers(1, 15);
        Console.WriteLine(number);  
    }

    static string PrintNumbers(int first, int last)
    {
        // Base condition to handle null/out of bounds
        if (first > last) 
            return ""; //<- need "" for returning nothing in string
        // O(n) time complexity

        //Print the first number til max 
        return first + " " + PrintNumbers(first + 1, last);

    }
}
