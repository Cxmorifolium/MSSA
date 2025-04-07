// 1. Create a console application in C# to store and print personal details of a person like name, age and address on console screen. Make use of appropriate variables.
// Note: new .NET frame doesn't need using System and can read top-level like python.
// Coding via VS code

/* using System;

class Program {
    static void Main(string[] args) {
        // Declare and initialize variables
        string userName = "Hello Kitty";
        Console
        int userAge = 29;
        string userAddress = "1234 A Street Dr, City, State";

        // Print personal details
        Console.WriteLine($"Personal Details:\nName: {name}\nAge: {age}\nAddress: {address}");
    }
}

*/

//User input method

using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine() ?? ""; //string? negates warning CS8600 null variable warning

        Console.Write("Enter your age: ");
        int userAge = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your address: ");
        string userAddress = Console.ReadLine() ?? "";

        Console.WriteLine($"\n~*** Personal Details ***~:\n" +
                  $"Name: {userName}\n" +
                  $"Age: {userAge}\n" +
                  $"Address: {userAddress}");

    }
}
