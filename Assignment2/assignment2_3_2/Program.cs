// Design a tip calculator : enter the bill total, tip % and display grand total after adding tip.

using System;
using System.Globalization;

class Program {
    static void Main(string[] args) {

        // Prompt for bill total
        Console.Write($"Enter your total bill: $");

        // Parse the input string to decimal 
        decimal billTotal = Convert.ToDecimal(Console.ReadLine());

        // Prompt for tip percentage
        Console.Write("\nHow much would you like to tip percentwise?: ");
        decimal tipInput = Convert.ToDecimal(Console.ReadLine());

        // Calculate total tip
        decimal totalTip = billTotal * (tipInput / 100m);

        // Calculate grand total
        decimal grandTotal = billTotal + totalTip;

        // Output the grand total
        Console.WriteLine($"\nTip Percent: {tipInput/100m:P2}"); //P0 for practice but not necessary
        Console.WriteLine($"Tip Amount: {totalTip:C2}"); //C2 also for practice. currency decimal place of 2 "C2"
        Console.WriteLine($"Your Grand Total: {grandTotal:C2}");
    }
}

// Upgrades: add handling for null warning CS8600; CS8604 line 13/14 line 18/19 if yada yada try yada yada