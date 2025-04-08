/* Write a C# Sharp program to accept two integers and check whether they are equal or not.
Test Data :
Input 1st number: 5
Input 2nd number: 5
Expected Output :
5 and 5 are equal
Test Data :
Input 1st number: 5
Input 2nd number: 15
Expected Output :
5 and 15 are not equal 

add while loop until user initiates exit for challenge cus I suck at it. Decided to go bool method

Note: new .NET frame doesn't need using System and can read top-level like python.
Coding via VS code
*/

using System;
class Program {
    static void Main(string[] args) {

        bool programActive = true;

        //initiate while loop
        while (programActive) {

            //Ask user to input number. Use ReadLine
            Console.Write($"Are your numbers equal to each other? Let's find out! \n Please enter your first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Please enter your second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            // Check if numbers are equal or not
            if (firstNumber == secondNumber) {
                Console.Write($"{firstNumber} and {secondNumber} are equal! :) ");
            }

            else {
                Console.Write($"{firstNumber} and {secondNumber} are not equal :( ");
            }

            // handle user input
            while (true) {
                Console.Write("\nWould you like to compare another? (yes/no): ");
                string response = Console.ReadLine()?.ToLower() ?? "";

                if (response == "yes") {
                    break; // exit inner loop and continue
                } else if (response == "no") {
                    programActive = false;
                    Console.WriteLine("Exiting program. Goodbye!");
                    break;
                } else {
                    Console.WriteLine("Please respond with 'yes' or 'no'.");
                }
            }
        }
    }
}