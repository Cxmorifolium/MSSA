/*
 Write a program in C# Sharp to print the first n natural number using recursion.
Test Data :
How many numbers to print : 10
Expected Output :
10 9 8 7 6 5 4 3 2 1

print n and n - 1

*/


using System;

class Program
{
    static void Main(string[] args) 
    {
        PrintNaturalNum(10);
    }

    static void PrintNaturalNum (int s)
    {
        if (s<1)
            return;
        {   
            Console.Write(s +" ");
            PrintNaturalNum(s-1);
        }
    }
}
