// 3. Write a C# program to print the result of dividing two numbers. Print the quotient and remainder as well. Get the input from the user.
// Note: new .NET frame doesn't need using System and can read top-level like python.
// Coding via VS code

using System;
class Program {
    static void Main(string[] args) {
        //Ask user to input number. Use Parse function
        Console.Write("Please enter your first number (dividend): ");
        double dividend = Convert.ToDouble(Console.ReadLine()); 

        Console.Write("Please enter your second number (divisor): ");
        double divisor = Convert.ToDouble(Console.ReadLine()); 

        // Sum function
        double quotient =  dividend / divisor;
        double remainder = dividend % divisor;

        //Print output
        Console.WriteLine($"Your total is: {quotient} with remainder: {remainder}");
            
        }
}
