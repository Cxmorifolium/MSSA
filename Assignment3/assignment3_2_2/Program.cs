// Add two matrices

using System;

class Program 
{
    static void Main(string[] args) 
    {
        int size = 2; // Set matrix as 2x2

        // Instantiate two double matrices
        double[,] matrix1 = new double[size, size];
        double[,] matrix2 = new double[size, size];

        // Ask for user input
        Console.WriteLine("Enter values for Matrix 1:");
        ElementEntry(matrix1);

        Console.WriteLine("Enter values for Matrix 2:");
        ElementEntry(matrix2);

        // Display the matrices
        Console.WriteLine("The First Matrix is:");
        PrintMatrix(matrix1);

        Console.WriteLine("\nThe Second Matrix is:");
        PrintMatrix(matrix2);

        double[,] resultMatrix = MatrixAddition(matrix1, matrix2);

        Console.WriteLine("\nThe addition of two matrices is:");
        PrintMatrix(resultMatrix);
    }

    static void ElementEntry(double[,] matrix)
    {
        int size = matrix.GetLength(0);

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write($"Please enter a value for Element [{i},{j}]: ");
                matrix[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }
    }

    static double[,] MatrixAddition(double[,] matrix1, double[,] matrix2)
    {
        int size = matrix1.GetLength(0);
        double[,] resultMatrix = new double[size, size];

        for (int i = 0; i < size; i++) 
        {
            for (int j = 0; j < size; j++) 
            {
                resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return resultMatrix;
    }

    static void PrintMatrix(double[,] matrix) 
    {
        int size = matrix.GetLength(0);
        for (int i = 0; i < size; i++)
        {
            // Start each row with a vertical bar
            Console.Write("|");

            for (int j = 0; j < size; j++)
            {
                // Print the matrix element followed by a vertical bar
                Console.Write($" {matrix[i, j]} |");
            }

            // Move to the next line after printing each row
            Console.WriteLine();
        }
    }
}
