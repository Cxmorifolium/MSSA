/*
1. You have a long flowerbed in which some of the plots are planted, and some are not. However, flowers cannot be planted in adjacent plots.
Given an integer array flowerbed containing 0's and 1's, where 0 means empty and 1 means not empty, and an integer n, return true if n new flowers can be planted in the flowerbed without violating the no-adjacent-flowers rule and false otherwise.

Example 1:
Input: flowerbed = [1,0,0,0,1], n = 1
Output: true

Example 2:
Input: flowerbed = [1,0,0,0,1], n = 2
Output: false 

Greedy Algorithm

What a confusing problem statement. it is not asking to plant flower beds but flowers 
e.g [1, 0, 1, 0, 1] the method checks can we plant at index 0? no there's a flower there
Can we plant at index 1, no there's plants besides it. thus this plot cannot plant flowers
However: [1, 0, 0, 0, 1]. can we plant at 1? no there's a flower ther, 0? no there's a flower to the right
the middle? yes there's no flower to the right and left and at current index. etc

Set index at 0 in [] in loop
at each index i check if it's empty and if the left& right neighbor empty or out of bounds
if it's true set flowerbed[i] =1, decrease n by i
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] flowerbed = {1, 0, 0, 0, 1};
        int n = 1;

        bool result = CanPlaceFlowers(flowerbed, n);
        Console.WriteLine(result);

    }

//O(n) time complexity 
    static bool CanPlaceFlowers(int[] flowerbed, int n)
    { // Starting at index 0, to the length of the array, incremeting
        for (int i = 0; i < flowerbed.Length; i++)
        {   // First, check if the index 0 is empty. 
            // If it is, check if the one to the right is empty too (since the left doesn't exist). 
            // Then move to the next index: is it empty? If it is, check if both the left and right neighbors are empty. 
            // Keep doing this for each index.
            if (flowerbed[i] == 0 && (i == 0 || flowerbed[i-1] ==0) && (i == flowerbed.Length-1 || flowerbed[i+1] ==0))
            {
                flowerbed[i] = 1; // Can plant
                n--; // check the next index
                if (n == 0) return true; // Complete
            }
        
        }
        return n <= 0; // If not done continue loop
    }
}
