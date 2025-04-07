// 2. Write a C# program to print the sum of two numbers. Get the input from user.
// Note: new .NET frame doesn't need using System and can read top-level like python.
// Coding via VS code

using System;
class Program {
    static void Main(string[] args) {
        //Ask user to input number. Use Parse function
        Console.Write("Please enter your first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine()); 

        Console.Write("Please enter your second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine()); 

        // Sum function
        double sum = num1 + num2;

        //Print output
        Console.WriteLine($"Your total is: {sum}");
            
        }
}

