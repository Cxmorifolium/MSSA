/*
Write a program in C# Sharp to count the frequency of each element of an array.
Test Data :
Input the number of elements to be stored in the array :3
Input 3 elements in the array :
element - 0 : 25
element - 1 : 12
element - 2 : 43
Expected Output :
Frequency of all elements of array :
25 occurs 1 times
12 occurs 1 times
43 occurs 1 times
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

        CountFrequency(array);

    }

    // static void CountFrequency (int[] nums)
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

    //         Console.WriteLine($"{nums[i]} occurs {count} times.");
    //         counted[i] = true;
    //     }
    // }

    static void CountFrequency(int[] nums)
    {
        Dictionary<int, int> frequencyCount = new Dictionary<int, int>();

        // Count occurrences of each number
        foreach (int num in nums)
        {
            if (frequencyCount.ContainsKey(num))
            {
                frequencyCount[num]++;
            }
            else
            {
                frequencyCount[num] = 1;
            }
        }

        foreach (var pair in frequencyCount)
        {
            Console.WriteLine($"{pair.Key} occurs {pair.Value} times.");
        }
    }

}