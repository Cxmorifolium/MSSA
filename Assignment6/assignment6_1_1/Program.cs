/*1. Implement a single linked list with each node representing a house. 
You may add data in it like house number, brief address, type of house ( like Ranch, Colonial) . 
Each house (node) will be linked to next. 
Give facility to the user to search a house by its number and then display the details. */

using System.Collections.Generic;
using System;

class Program
{
    static void Main(string[] args)
    {
        HouseList list = new HouseList();

        list.AddHouse(132382, "W 21st St.", "Duplex");
        list.AddHouse(1233, "W Pecan Ct.", "Cottage");
        list.AddHouse(4323, "Parmesan View", "Ranch");
        list.AddHouse(231, "S Havarti St.", "Resort");

        list.RemoveHouse(132382);

        bool running = true;

        while (running)
        {
            Console.WriteLine("Menu (Please choose between 1-5): ");
            Console.WriteLine("1. Add House");
            Console.WriteLine("2. Display All Houses");
            Console.WriteLine("3. Search House by House Number");
            Console.WriteLine("4. Remove House");
            Console.WriteLine("5. Exit");

            string input = Console.ReadLine();
            
            switch (input)
            {
                case "1":
                    Console.Write("Enter house number: ");
                    int number = int.Parse(Console.ReadLine());
                    Console.Write("Enter address: ");
                    string address = Console.ReadLine();
                    Console.Write("Enter type of house: ");
                    string type = Console.ReadLine();
                    list.AddHouse(number, address, type);
                    break;
                case "2":
                    list.DisplayAll();
                    break;
                case "3":
                    Console.Write("Enter house number to search: ");
                    int searchNum = int.Parse(Console.ReadLine());
                    list.SearchHouse(searchNum);
                    break;
                case "4":
                    Console.Write("Enter house number to remove: ");
                    int removeNum = int.Parse(Console.ReadLine());
                    list.RemoveHouse(removeNum);
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid Option. Please enter a value between 1-5 to choose.");
                    break;
            }

        }

        Console.WriteLine("Please come again!");
    }
}

// Handle nulls next time. 
// CS8600, 8602, 8618, 8604,