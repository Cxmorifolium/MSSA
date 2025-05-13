/*Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

You must write an algorithm that runs in O(n) time and without using the division operation.

Example 1:

Input: nums = [1,2,3,4]

Output: [24,12,8,6]

Example 2:

Input: nums = [-1,1,0,-3,3]

Output: [0,0,9,0,0]

*/

using System;

class Program
{
    static void Main(string[] args)
    {
        // tested on leetcode
    }

    static int[] ProductExceptSelf(int[] nums)
    {
        //Initialize array starting at index[0] = 1 since we know there's no index before it
        int[]answer - new int[nums.Length];
        answer[0] = 1; 

        //Prefix logic left to right
        int prefix = 1; //since we know it starts at 1 and then accumulate from here
        for(int i = 0; i < nums.Length; i++)
        {
            answer[i] = answer[i-1]*nums[i-1]; //the mathematical equation
        }

        //Suffix logic, right to left
        int suffix = 1;
        for (int i = nums.Length - 1; i>=0; i--)
        {
            answer[i] *= suffix; // multiply current value by suffix product
            suffix *= nums[i]; // update product
        }
        return answer;

    } 
}

/* so answer [i] = product of all other numbers except current index nums
After googling the logic, it is as follows:
Prefix[] you go from left to right since index[0] has nothing before it, it's product is nums[0]
example: [1,2,3,4]
index[0] = 1
index[1] will then be nums[0] = 1
index[2] will be nums[0]*nums[1]= 1*2
index[3] will be num[0]*num[1]*nums[2] = 1*2*3
prefix[] = [1, 1, 2, 6]

suffix index is then the reverse
example: [1,2,3,4]
index[3] = 1, there are no elements to after last index
index[2] = num[3] = 4
index[1] = num[3]*num[2] = 12
index[0] = num[3]*num[2]*num[1] = 24
suffix[] = [24 12 4 1]

then prefix x suffix

MEDIUM LEETCODE!!!
*/