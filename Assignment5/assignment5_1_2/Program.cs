/*
2. Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
Test Data :
Enter a number: 1234
Expected Output :
The sum of the digits of the number 1234 is : 10
*/

using System;

class Program 
{
    static void Main(string[] args)
    {
        int num = 1234;
        Console.WriteLine($"Num: {num} = Sum: {AddDigits(num)}");

    }

    static int AddDigits(int n)
    {
        int sum = 0; // sum is 0
        while (n > 0) // while the n is greater than 0
        {
            int digit = n % 10; // take the last digit
            sum += digit; // add it to the sum which is currently -
            n = n / 10; // remove the last digit
        }
        return sum;

        // int sum = 0;
        // while (target>0)
        // {
        //     sum = sum + target%10;
        //     target /= 10;
        // } the easier method
    }

}