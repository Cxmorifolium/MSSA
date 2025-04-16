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

// // USER INPUT
// class Program {
//     static void Main(string[] args) {
//         // Prompt for User Input
//         Console.WriteLine("Please enter three numbers seperated by a space to begin finding the largest value: ");
        
//         // Read User Input
//         string userInput = Console.ReadLine();

//         // Split the line based on space for elements
//         string[] elements = userInput.Split(' ');

//         // Create an array of converted double values by looping through each string  elmement
//         double[] numbers = new double[elements.Length];

//         for (int i = 0; i < numbers.Length; i++) {
//             numbers[i] = Convert.ToDouble(elements[i]);
//         }

//         // Declare variable max as the first element of the array
//         double max = numbers[0];

//         // Loop through each element and compare against initial max variable
//         for (int i = 0; i < numbers.Length; i++) {
//             if (numbers[i] > max) {
//                 max = numbers[i];
//             }
//         }

//         // Output on console
//         Console.WriteLine($"The largest number is: {max}");

//     }
// }

// // Creating an array with random number of elements and numbers
// class Program {
//     public static void Main(string[] args) { 

//         Random random = new Random(); //Instantiating random

//         int n = random.Next(3, 10); // generate 3-10 random elements

//         // Create array
//         int[] numbers = new int[n];
//         for (int i = 0; i < n; i++) {
//             numbers[i] = random.Next(1, 101); // Random numbers between 1 and 100
//         }

//         // Output the random integers to see what it generated
//         Console.WriteLine($"Generated {n} random numbers:");
//         foreach (int num in numbers) {
//             Console.Write(num + " ");
//         }
//         Console.WriteLine();

//         // Find the max by comparing to first element
//         int max = numbers[0];
//         foreach (int num in numbers) {
//             if (num > max) {
//                 max = num;
//             }
//         }

//         // Output the result
//         Console.WriteLine($"The largest number is: {max}");
//     }
// }

// Other method is to use built in MAX function.

using System.Linq;

class Program {
    static void Main(string[] args) {

        int[] numbers = { 1, 50, 22, 7 };

        int max = numbers.Max();

        Console.WriteLine($"The max value is {max}");
    }
}