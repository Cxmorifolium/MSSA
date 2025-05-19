/*You are a student who has recently taken an exam with your classmates. 
However, the professor has not yet provided the students with a sorted list of exam scores. 
To make things easier, you write a program to sort exam scores in ascending order using the selection sort algorithm. 
This way, you can obtain the sorted list of scores and see how you performed compared to your classmates. 
Also, you choose selection sort since that is an easy way of implementation. */

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] grades = { 100, 90, 20, 40, 0, 95, 84, 75, 60, 93, 95, 88 };
        SelectionSort(grades);
        foreach (int grade in grades) Console.Write(grade + " ");

    }

    static void SelectionSort(int[] A)
    {
        int minPosition = 0; //l to r
        int temp = 0;

        // i is tracking the correct position to put the element
        for (int i = 0; i < A.Length - 1; i++)
        {
            // minPosition tracks the index of the min number
            minPosition = i;
            for (int j = i + 1; j < A.Length; j++)
            {
                if (A[j] < A[minPosition]) // logic to find min number
                {
                    minPosition = j; // update the minPosition with index of min number
                }
            }

            if (minPosition != i)
            {
                temp = A[i];
                A[i] = A[minPosition];
                A[minPosition] = temp;
            }
        }
    }
}