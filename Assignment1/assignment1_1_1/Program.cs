// 1. Create a console application in C# to store and print personal details of a person like name, age and address on console screen. Make use of appropriate variables.

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
        string userName = Console.ReadLine();

        Console.Write("Enter your age: ");
        int userAge = Convert.ToInt32(Console.ReadLine())!;

        Console.Write("Enter your address: ");
        string userAddress = Console.ReadLine();

        Console.WriteLine($"\n~*** Personal Details ***~:\n" +
                          $"Name: {name}\n" +
                          $"Age: {age}\n" +
                          $"Address: {address}");
    }
}
