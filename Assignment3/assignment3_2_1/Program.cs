// Create a 2D array to store integers and print them in matrix format with proper formatting.

using System;

class Program 
{
    static void Main(string[] args) 

    {

        int[,] twoD = {  {1, 2, 3 }, 
                         {4, 5, 6 } 
                      };
        
        for (int i = 0; i < twoD.GetLength(0); i++) // rows
        {
            for (int j = 0; j < twoD.GetLength(1); j++) // columns
            {
                Console.Write(twoD[i, j] + " ");
            }
            Console.WriteLine(); // new line
        }

    }

}