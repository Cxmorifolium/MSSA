/* 
Divisible by 2 or 3

Given two integers, write a method that returns their multiplication if they are both divisible by 2 or 3, otherwise returns their sum.

Expected input and output

DivisibleBy2Or3(15, 30) → 450 DivisibleBy2Or3(2, 90) → 180 DivisibleBy2Or3(7, 12) → 19 
*/

using System;

class Program 
{
    static void Main(string[] args) 
    {
        int a = 45;
        int b = 7;

        Console.WriteLine($"DivisibleBy2Or3({a}, {b}) -> {DivisibleBy2Or3(a, b)}");
    }

    static double DivisibleBy2Or3(int a, int b)
    {
        if ((a % 3 == 0 || a % 2 == 0) && (b % 3 == 0 || b % 2 == 0))
            return a * b;
        else
            return a + b;
    }


}