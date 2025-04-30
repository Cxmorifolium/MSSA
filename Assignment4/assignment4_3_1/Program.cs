/*
Write a program in C# Sharp to calculate and print the Electricity bill of a given customer. 
The customer id., name and unit consumed by the user should be taken from the keyboard and display the total amount to pay to the customer. 
The charge are as follows: (you may change the charge sheet values)
Unit Charge/unit
upto 199 @1.20
200 and above but less than 400 @1.50
400 and above but less than 600 @1.80
600 and above @2.00

Expected Output :
Customer IDNO :1001
Customer Name :James
unit Consumed :800
Amount Charges @$ 2.00 per unit : 1600.00
Surcharge Amount : 240.00
Net Amount Paid By the Customer : 1840.00
*/

using System;
class Program {
    static void Main(string[] args)
    {
        Console.Write("Enter Customer ID : ");
        string customerID = Console.ReadLine();

        Console.Write("Enter Customer Name : ");
        string customerName = Console.ReadLine();

        Console.Write("Enter Units Consumed : ");
        int units = Convert.ToInt32(Console.ReadLine());

        double totalBill = 0;
        double surcharge = 0;
        double tier1 = 0, tier2 = 0, tier3 = 0, tier4 = 0;

        if (units <= 199)
        {
            tier1 = units * 1.2;
        }
        else if (units <= 399)
        {
            tier1 = 199 * 1.2;
            tier2 = (units - 199) * 1.5;
        }
        else if (units <= 599)
        {
            tier1 = 199 * 1.2;
            tier2 = 200 * 1.5;
            tier3 = (units - 399) * 1.8;
        }
        else
        {
            tier1 = 199 * 1.2;
            tier2 = 200 * 1.5;
            tier3 = 200 * 1.8;
            tier4 = (units - 599) * 2.0;
        }

        totalBill = tier1 + tier2 + tier3 + tier4;

        if (totalBill > 400)
        {
            surcharge = totalBill * 0.15;
            totalBill += surcharge;
        }

        Console.WriteLine();
        Console.WriteLine($"Customer IDNO                    : {customerID}");
        Console.WriteLine($"Customer Name                    : {customerName}");
        Console.WriteLine($"Unit Consumed                    : {units}");
        Console.WriteLine();

        if (tier1 > 0)
            Console.WriteLine($"Tier 1: 0-199 units @ $1.20      : ${tier1:F2}");
        if (tier2 > 0)
            Console.WriteLine($"Tier 2: 200-399 units @ $1.50    : ${tier2:F2}");
        if (tier3 > 0)
            Console.WriteLine($"Tier 3: 400-599 units @ $1.80    : ${tier3:F2}");
        if (tier4 > 0)
            Console.WriteLine($"Tier 4: 600+ units @ $2.00       : ${tier4:F2}");

        Console.WriteLine();
        Console.WriteLine($"Subtotal                         : ${tier1 + tier2 + tier3 + tier4:F2}");

        if (surcharge > 0)
            Console.WriteLine($"Surcharge (15%)                  : ${surcharge:F2}");
        Console.WriteLine($"Net Amount Paid By the Customer  : ${totalBill:F2}");
    }
}