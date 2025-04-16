// Write a C# Sharp program that takes userid and password as input (type string). 
// After 3 wrong attempts, user will be rejected.
// Extremely basic

using System;
using System.Security.Cryptography;
using System.Text;

class Program {
    static void Main(string[] args) {

        // Username and password created
        var username = "hellokitty";
        var password = "1234abcd";

        // Initialize counter, max attempts, and entries
        int counter = 0;
        int maxAttempt = 3;
        string usernameEntry, passwordEntry;

        // do-while for entry and error
        do {
            // Ask for username
            Console.WriteLine("Enter your username: ");
            usernameEntry = Console.ReadLine();

            // Ask for password
            Console.WriteLine("Enter your password: ");
            passwordEntry = Console.ReadLine();

            // if un and pass match give msg and break from loop
            if (usernameEntry == username && passwordEntry == password) {
                Console.Write("\nWelcome!");
                break;
            }
            // else increase counter and output msg with remaining attempts left
            else {
                counter++; // Increase counter
                int remainingAttempts = maxAttempt - counter;
                if (remainingAttempts > 0) {
                    Console.WriteLine($"Incorrect username or password. You have {remainingAttempts} attempt(s) left.\n");
                }
            }

        } 
        
        while (counter < maxAttempt); // while counter is less than 3 loop continues

        if (counter == maxAttempt) {
            Console.WriteLine("\nMax attempts reached. Please reset your password.\n");
        } // when it reaches 3 attempts, it terminates w a msg
    }
}

// Next: implement hash + salt methods, password/user in .json or something