// Implement shell sort on an unsorted array of numbers. Take the array input from user.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a series of numbers with spaces in between: ");
        int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        ShellSort(input);
        Console.WriteLine("Sorted numbers:");
        foreach (int num in input)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

    }

    static void ShellSort(int[] arr)
    {
        int n = arr.Length;
        int gap = n / 2;
        
        while (gap > 0)
        {
            for (int i = gap; i < n; i++)
            {
                int temp = arr[i]; // number to be placed in correct position
                int j = i;
                
                // Shift elements that are greater than temp
                while (j >= gap && arr[j - gap] > temp)
                {
                    arr[j] = arr[j - gap];
                    j -= gap;
                }
                
                arr[j] = temp;
            }
            
            gap = gap / 2;
        }
    }

}
