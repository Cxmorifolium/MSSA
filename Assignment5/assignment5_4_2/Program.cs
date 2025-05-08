/*
Write a C# Sharp program to find the sum of the right diagonals of a matrix.
Test Data :
Input the size of the square matrix : 2
Input elements in the first matrix :
element - [0],[0] : 1
element - [0],[1] : 2
element - [1],[0] : 3
element - [1],[1] : 4
Expected Output :
The matrix is :
1 2
3 4
Addition of the right Diagonal elements is :5 */

/* Recursion method:
[11][12][13]
[21][22][23]
[31][32][33]

Square matrix; userinput
Common factor [index, index] adds one each time starting at index 0
GetLength method is useful

*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input the size of the square matrix: ");
        int size = int.Parse(Console.ReadLine()); //Note: int.Parse will give null warning

        int[,] matrix = new int[size, size];

        Console.WriteLine("Input elements in the matrix:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write($"element - [{i},{j}] : ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int diagonalSum = DiagonalSum(matrix);
        Console.WriteLine("Sum of the right diagonal is: " + diagonalSum);
    }

    static int DiagonalSum (int[,] matrix, int index = 0)
    {
        //Matrix property GetLength() finds number of rows
        int size = matrix.GetLength(0);

        // Base Condition: if the index exceed the side = outofbounds/nukk
        if (index >= size)
            return 0;
        
        // Otherwise
        return matrix[index, index] + DiagonalSum(matrix, index + 1);
    }
}