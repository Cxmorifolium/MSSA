/*
Write a C# Sharp program to find the largest of three numbers.
Test Data :
Input the 1st number :25
Input the 2nd number :63
Input the 3rd number :10
Expected Output :
The 2nd Number is the greatest among three
*/

using System;

class Program {
    static void Main(string[] args) {
        // Prompt for User Input
        Console.WriteLine("Please enter three numbers seperated by a space to begin finding the largest value: ");
        
        // Read User Input
        string userInput = Console.ReadLine();

        // Split the line based on space for elements
        string[] elements = userInput.Split(' ');

        // Create an array of converted double values by looping through each string  elmement
        double[] numbers = new double[elements.Length];

        for (int i = 0; i < numbers.Length; i++) {
            numbers[i] = Convert.ToDouble(elements[i]);
        }

        // Declare variable max as the first element of the array
        double max = numbers[0];

        // Loop through each element and compare against initial max variable
        for (int i = 0; i < numbers.Length; i++) {
            if (numbers[i] > max) {
                max = numbers[i];
            }
        }

        // Output on console
        Console.WriteLine($"The largest number is: {max}");

    }
}