// 2. Write a C# program to print the sum of two numbers. Get the input from user.

using System;
class Program {
    static void Main(string[] args) {
        //Ask user to input number. Use Parse function
        Console.Write("Please enter your first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine()); 

        Console.Write("Please enter your second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine()); 

        // Sum function
        int sum = num1 + num2;

        //Print output
        Console.WriteLine($"Your total is: {sum}");
            
        }
}

