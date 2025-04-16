/* Write a C# Sharp program that takes a number and a width also a number, 
as input and then displays a triangle of that width, using that number.
Test Data
Enter a number: 6
Enter the desired width: 6
Expected Output:

666666

66666

6666

666

66

6
*/

using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the desired width (number): ");
        int width = Convert.ToInt32(Console.ReadLine());

        // Initialize i = width, so long as it's greater than 1, decrease by 1
        for (int i = width; i >= 1; i--) {
            string printNumber = number.ToString();
            string line = "";
            // loop until i goes to 1
            for (int j = 0; j < i; j++) {
                line += printNumber;
            }
            Console.WriteLine(line);
        }

    }
}
