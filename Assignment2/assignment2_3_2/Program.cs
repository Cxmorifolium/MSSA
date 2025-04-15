// Design a tip calculator : enter the bill total, tip % and display grand total after adding tip.

using System;
using System.Globalization;

class Program {
    static void Main(string[] args) {

        // Prompt for bill total
        Console.WriteLine($"Enter your total bill: {NumberFormatInfo.CurrentInfo.CurrencySymbol}");

        // Parse the input string to decimal 
        decimal billTotal = Convert.ToDecimal(Console.ReadLine());

        // Prompt for tip percentage
        Console.WriteLine("How much would you like to tip?");
        decimal tipInput = Convert.ToDecimal(Console.ReadLine());

        // Calculate total tip
        decimal totalTip = billTotal * (tipInput / 100m);

        // Calculate grand total
        decimal grandTotal = billTotal + totalTip;

        // Output the grand total
        Console.WriteLine($"Your grand total is: {NumberFormatInfo.CurrentInfo.CurrencySymbol}{grandTotal:F2}");
    }
}

// Upgrades: add handling for null warning CS8600; CS8604 line 13/14 line 18/19 if yada yada try yada yada