/* If year is leap
Given a year as integer, write a method that checks if year is leap. 

I didn't do that but i did output years that's leap year*/

using System;
using System.Text;

class Program 
{
    static void Main(string[] args) 
    {
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        // Call Method
        if (IsLeapYear(year))
        {
            Console.WriteLine("It's a leap year!");
        }
        else
        {
            Console.WriteLine("It's not a leap year.");
        }
    }

    // Write method to check for leap year edge cases
    static bool IsLeapYear(int year)
    {
        if (year % 4 != 0)
            return false;
        else if (year % 100 != 0)
            return true;
        else if (year % 400 == 0)
            return true;
        else
            return false;
    }
}