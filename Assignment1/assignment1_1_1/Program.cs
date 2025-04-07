// 1. Create a console application in C# to store and print personal details of a person like name, age and address on console screen. Make use of appropriate variables.

using System;

class Program {
    static void Main(string[] args) {
        // Declare and initialize variables
        string name = "Cathy Nguyen";
        int age = 29;
        string address = "1234 A Street Dr, City, State";

        // Print personal details
        Console.WriteLine($"Personal Details:\nName: {name}\nAge: {age}\nAddress: {address}");
    }
}
