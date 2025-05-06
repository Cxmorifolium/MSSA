/*
 Write a program in C# Sharp to print the first n natural number using recursion.
Test Data :
How many numbers to print : 10
Expected Output :
1 2 3 4 5 6 7 8 9 10 

print n and n + 1

*/


using System;

class Program
{
    static void Main(string[] args) 
    {
        PrintNaturalNum(1);
    }

    static void PrintNaturalNum (int s)
    {
        if (s>10)
            return;
        {   
            Console.Write(s +" ");
            PrintNaturalNum(s+1);
        }
    }
}
