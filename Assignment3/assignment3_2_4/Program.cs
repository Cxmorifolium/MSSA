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
        Console.WriteLine("Please enter 4 numbers follow by a space: ");
        string input = Console.ReadLine();

        string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        double[] numbers = parts.Select(part => double.Parse(part)).ToArray(); // => replaces FOREACH hehehe learning something new

        double sum = numbers.Sum();
        double average = numbers.Average();

        Console.WriteLine($"The Sum of the numbers is {sum} and the average is {average}");
    }
}