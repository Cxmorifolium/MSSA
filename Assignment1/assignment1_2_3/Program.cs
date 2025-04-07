/* 
3. Write a menu driven application to perform calculation functions like addition, subtraction, multiplication, and division. 
Call them appropriately when user selects the option. Give the user the option to continue or exit the program.

bool, for/while, switch case application!
Note: new .NET frame doesn't need using System and can read top-level like python.
Coding via VS code

*/
using System;

class Program {
    static void Main(string[] args) {
        bool programActive = true;

        while (programActive) {
            // Create menu:
            Console.WriteLine(
                "Welcome to the Calculator where you can only conduct math with two integers.\n" +
                "Please select from the following:\n" +
                "1. Addition\n" +
                "2. Subtraction\n" +
                "3. Multiplication\n" +
                "4. Division\n" +
                "5. Exit");

            // Ask for input:
            string option = Console.ReadLine()!;

            // If exit is selected
            if (option == "5") {
                programActive = false;
                Console.WriteLine("Goodbye!");
                break; // Exit the loop
            }

            // Input numbers. Use double to handle decimal/negative inputs
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // The switch case!!
            switch (option) {
                case "1": // Addition
                    Console.WriteLine($"The sum is: {num1 + num2}");
                    break;
                case "2": // Subtraction
                    Console.WriteLine($"The difference is: {num1 - num2}");
                    break;
                case "3": // Multiplication
                    Console.WriteLine($"The product is: {num1 * num2}");
                    break;
                case "4": // Division. Handle division by zero
                    if (num2 != 0) {
                        Console.WriteLine($"The quotient is: {num1 / num2}");
                    } else {
                        Console.WriteLine("Error: Cannot divide by zero.");
                    }
                    break;
                default: // Invalid input
                    Console.WriteLine("Invalid option. Please choose 1-5.");
                    break;
            }

            // Handle null/User input
            while (true) {
                Console.Write("\nWould you like to do another calculation? (yes/no): ");
                string response = Console.ReadLine()?.ToLower() ?? "";

                if (response == "yes") {
                    break; // Exit inner loop and continue
                } else if (response == "no") {
                    programActive = false;
                    Console.WriteLine("Exiting program. Goodbye!");
                    break;
                } else {
                    Console.WriteLine("Please respond with 'yes' or 'no'.");
                }
            }
            Console.WriteLine(""); // Add space between loops
        }
    }
}
