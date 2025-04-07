/* Write a C# Sharp program to find the sum of first 10 natural numbers.
Expected Output :
The first 10 natural number is :
1 2 3 4 5 6 7 8 9 10
The Sum is : 55

Note: new .NET frame doesn't need using System and can read top-level like python.
Coding via VS code
Method: for loop set from 1-10; initialize sum at 0 
*/

using System;

class Program {
    static void Main(String[] args) {

        int sum = 0;

        Console.WriteLine("The first 10 natural numbers are: ");

        for (int i = 1; i <=10; i++) {
            // Write console to show natural number
            Console.Write(i + " ");

            // Add each number
            sum += i;

        }

        Console.WriteLine($"\nThe Sum is: {sum}");
    }
}
