// 1. If number contains 3 Write a method that checks if given number (positive integer) contains digit 3. 
//Do not convert number to other type. Do not use built-in functions like Contains(), StartsWith(), etc.

using System;

class Program {
    static void Main(string[] args) {
        int num = 342;
        CheckFor3(num);

    }

    // static void CheckFor3(double num)
    // {
    //     string str = num.ToString();
    //     bool containsThree = false;

    //     foreach (char c in str)
    //     {
    //         if (c == '3') 
    //         {
    //             containsThree = true;
    //             break;
    //         }
    //     }

    //     Console.WriteLine($"CheckFor3 {num} -> {containsThree}");
    // }


    static void CheckFor3(int num)
    {
        int wholeNum = Math.Abs(num); // negate negatives
        bool containsThree = false;

        while (wholeNum > 0)
        {
            int digit = wholeNum % 10;
            if (digit == 3)
            {
                containsThree = true;
                break; // no need to continue checking once we've found a 3
            }
            wholeNum /= 10;
        }

        Console.WriteLine($"CheckFor3 {num} -> {containsThree}");
    }

}
