/*
3. Write a program in C# Sharp to print all unique elements in an array.
Test Data :
Input the number of elements to be stored in the array :3
Input 3 elements in the array :
element - 0 : 1
element - 1 : 5
element - 2 : 1
Expected Output :
The unique elements found in the array are :
5
*/

using System;

class Program {
    static void Main(string[] args) 
    {
        Console.Write("Input number of elemnts to be stored in array: ");
        int elements = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[elements];

        Console.WriteLine($"Input {elements} elements in the array: ");
        for (int i = 0; i < elements; i++)
        {
            Console.Write($"element - {i}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        UniqueElement(array);

    }

    // static void UniqueElement (int[] nums)
    // {
    //     int arrSize = nums.Length;
    //     bool[] counted = new bool[arrSize];

    //     // This loop starts at index [0] and then count and compare elements against it adding to count if condition meets
    //     // Then it goes to index [1] and compare the elements against it adding to count if condition meets; etc.
    //     for (int i = 0; i < arrSize; i++)
    //     {
    //         if (counted[i]) continue;

    //         int count = 1;
    //         for (int j = i + 1; j < arrSize; j++)
    //         {
    //             if (nums[i] == nums[j])
    //             {
    //                 count++;
    //                 counted[j] = true;
    //             }
    //         }

    //         if (count == 1)
    //         {
    //             Console.WriteLine($"{nums[i]} is unique.");
    //         }

    //         counted[i] = true;
    //     }
    // }

    static void UniqueElement(int[] nums)
    {
        Dictionary<int, int> elementCounts = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (elementCounts.ContainsKey(num))
            {
                elementCounts[num]++;
            }
            else
            {
                elementCounts[num] = 1;
            }
        }

        Console.WriteLine("The unique elements found in the array are:");
        foreach (var pair in elementCounts)
        {
            if (pair.Value == 1)
            {
                Console.WriteLine(pair.Key);
            }
        }
    }
}