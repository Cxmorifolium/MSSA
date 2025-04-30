// 1. If number contains 3 Write a method that checks if given number (positive integer) contains digit 3. 
//Do not convert number to other type. Do not use built-in functions like Contains(), StartsWith(), etc.

using System;

class Program {
    static void Main(string[] args) {
        int testCase = 342;
        Console.WriteLine($"{testCase}");
        Check3(testCase);

    }

    static void Check3(double num) 
    {
        string str = num.ToString();

        foreach (char c in str) {
            if (c == '3') {
                Console.WriteLine("It contains the number 3!");
                return;
            }
        }
        Console.WriteLine("It does not contain the number 3.");
    }
}
