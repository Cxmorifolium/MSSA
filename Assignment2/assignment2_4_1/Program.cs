/*
1. Write a program in C# Sharp to find the sum of all array elements.
Test Data :
Input the number of elements to be stored in the array :3
Input 3 elements in the array :
element - 0 : 2
element - 1 : 5
element - 2 : 8
Expected Output :
Sum of all elements stored in the array is : 15
*/

using System;

class Program {
    static void Main(string[] args) {
        
        // Ask user to enter the number of elements they want to store in array
        Console.WriteLine("Please enter the number of elements you'd like in an array: ");

        int userInput = Convert.ToInt32(Console.ReadLine());

        // Create an array to store elements
        int[] elements = new int[userInput];

        // Method created below, call here
        ElementEntry(elements);

        // Initialize array 
        int sum = 0;

        // Sum up all elements in array
        foreach (int element in elements)
        {
            sum += element;
        }

        Console.WriteLine($"The sum of the array is: {sum} ");

    }

    // Method to retrieve user input based on how many elements they want in an array
    static void ElementEntry(int[] array) {
        // Loop through array to get values from the user
        for (int i = 0; i < array.Length; i++) {
            // Ask user to enter their value
            Console.WriteLine($"Please enter a value for Element [{i}]: ");
            // Read user input and store it in the array
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
}
