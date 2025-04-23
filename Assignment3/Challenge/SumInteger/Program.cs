/// 2. Sum digits in string
/// Given a string, write a method which returns
/// sum of all digits in that string. Assume that
/// string contains only single digits.
/// Expected input and output
/// SumDigitsInString("1q2w3e") → 6
/// SumDigitsInString("L0r3m.1p5um") → 9
/// SumDigitsInString("") → 0

using System;

class Program {
    static void Main(string[] args) 
    {
        Console.Write("Input phrase: ");
        Console.WriteLine(SumDigitsInString(Console.ReadLine()));
    }

    static int SumDigitsInString(string input)
    {
        int sum = 0;
        foreach (char c in input)
        {
            if (c >= '0' && c <= '9')
            {
                sum += c - '0';
            }
        }
        return sum;
    }

    // static int SumDigitsInString(string input)
    // {
    //     int sum = 0;
    //     foreach (char c in input)
    //     {
    //         if(char.IsDigit(c)) sum=sum+(Convert.ToInt32(c)-48); // 48 is the ASCII Values
    //     }
    //     return sum;
    // }
}
