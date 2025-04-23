/*
Write a function that takes 4 numbers as input to calculate the total and average.
(Make use of params array to pass arguments and out parameters to return both total and average to main method).
Test Data:
Enter the First number: 10
Enter the Second number: 15
Enter the third number: 20
Enter the fourth number: 30
*/

using System;

class Program 
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter 4 numbers followed by a space: ");
        string input = Console.ReadLine();

        string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        double[] numbers = parts.Select(part => double.Parse(part)).ToArray(); // hehehe another new annotation "looping through iteration"

        CalculateTotalAndAverage(out double sum, out double average, numbers);

        Console.WriteLine($"The Sum of the numbers is {sum} and the average is {average}");
    }

    static void CalculateTotalAndAverage(out double total, out double average, params double[] numbers)
    {
        total = numbers.Sum();
        average = numbers.Average();
    }
}

// out is like return