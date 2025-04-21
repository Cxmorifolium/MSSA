/* 
Write a function which takes an array as input and finds the first occurrence of 2 consecutive 1s and changes their value to 0.
For e.g: Input : [0,2,1,1,9,1,1]
Output: [0,2,0,0,9,1,1]
*/

using System;

class Program {
    static void Main(string[] args) {
        
        int[] myArray = {1, 0, 2, 4, 4, 1, 1, 2};

        // Call method
        ConsecutiveNumbers(myArray);

        // Print new Array
        for (int i = 0; i < myArray.Length; i++) {
        Console.Write(myArray[i] + " ");
        }
    }

    // Wrapping in a method instead of main body
    static void ConsecutiveNumbers(int[] myArray) {
    // Comparing one element to its next element and see if it equals
        for (int i = 0; i < myArray.Length - 1; i++) {
            if (myArray[i] == 1 && myArray[i + 1] == 1) {
                myArray[i] = 0; // change it to 0
                myArray[i + 1] = 0; // change next element to 0
                break; // Exit at after changing first set of ones.
            }
        }
    }

}