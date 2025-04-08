/* Write a console application in C# to explore different ways 
in which array is declared and initialized and explore different properties and methods of Array class.

*/

using System;

class Program {
    static void Main(String[] args) {
    // Creating an array:

    // Single Dimensional Array
    int[] intArray;
    intArray = new int[3] {1, 2, 3};
    Console.WriteLine($"This is an array of intergers: \n{string.Join(", ", intArray)}");

    Console.WriteLine();

    string[] characterNames = {"Jon Snow", "Daenerys Targaryen", "Arya Stark"};
    Console.WriteLine($"This is a string array \n{string.Join(",",characterNames)}");

    Console.WriteLine();

    // Multi-Dimensional Array
    int[,] arrayNumbers = { {1, 2, 3}, 
                            {4, 5, 6}, 
                            {7, 8, 9} };

    // For Loop to print; GetLength returns number of rows and/or columns
    Console.WriteLine($"This is a multi-dimensional array of integers:");
    for (int i = 0; i < arrayNumbers.GetLength(0); i++)
    {
        for (int j = 0; j < arrayNumbers.GetLength(1); j++)
        {
            Console.Write(arrayNumbers[i, j] + " ");
        }
        Console.WriteLine(); // New line after each row to mimic matrix
    }

    Console.WriteLine();

    string[,] strawhatPirates = {   {"Luffy", "Sanji", "Zoro"}, 
                                    {"Nico Robin"," Nami", "Chopper"},
                                    {"Franky", "Brooks", "Usopp"}};

    Console.WriteLine($"This is a multi-dimensional string array containing names from the Straw Hat crew:");
    for (int i = 0; i < strawhatPirates.GetLength(0); i++)
    {
        for (int j = 0; j < strawhatPirates.GetLength(1); j++)
        {
            Console.Write(strawhatPirates[i, j] + " ");
        }
        Console.WriteLine(); // New line after each row to mimic matrix
    }

    Console.WriteLine();

    Console.WriteLine("Properties of Arrays can be accessed such as length and rank. " +
                    "Length tells you how many elements are in an array and Rank tells you how many dimensions the array has.");

    Console.WriteLine();

     /* Array properties:
    1. Length
    2. Rank
    3. Element
    etc....
    */

    // Using @ instead of $ \n each time ohohohoho
    Console.WriteLine($@"This is the property of intArry:
        Length: {intArray.Length}
        Rank: {intArray.Rank}");
    
    Console.WriteLine($@"This is the property of Straw Hat Pirates array:
        Length: {strawhatPirates.Length}
        Rank: {strawhatPirates.Rank}");

    Console.WriteLine();

    Console.WriteLine("If you know the dimension of the array, you can access an element, otherwise it'll return out of bounds");
    Console.WriteLine($"Element [0,2] of Straw Hat Array is: {strawhatPirates[2,2]}");

    Console.WriteLine();

        /* Array Methods:
            1. Sort()
            2. Reverse()
            3. Copy()
            4. Clone()
            5. IndexOf()
            6. Exists()
            7. Clear()
            8. Fill()

        */

    // Sort the strawhatPirates array
    Array.Sort(characterNames);

    // Reverse the intArray
    Array.Reverse(intArray);

    Console.WriteLine($@"There are many different array methods. Here are 2 that works on single dimension arrays:
        Sort (characterNames): {string.Join(", ", characterNames)}
        Reverse (intArray): {string.Join(", ", intArray)}");

    }
}