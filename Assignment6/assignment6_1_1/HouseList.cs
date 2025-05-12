using System;
using System.Collections.Generic;

public class HouseList
{
    private House head;

    public void AddHouse(int number, string address, string type)
    {
        House newHouse = new House(number, address, type);
        if (head == null)
        {
            head = newHouse;
        }
        else
        {
            House current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newHouse;
        }
    }

    public void SearchHouse(int number)
    {
        House current = head;
        while (current != null)
        {
            if (current.HouseNumber == number)
            {
                Console.WriteLine($"House Number: {current.HouseNumber}");
                Console.WriteLine($"Address: {current.Address}");
                Console.WriteLine($"Type: {current.TypeOfHouse}");
                return;
            }
            current = current.Next;
        }
        Console.WriteLine("House not found.");
    }

    public void RemoveHouse (int number)
    {
        if (head == null)
        {
            Console.WriteLine("The list is empty. Nothing to remove.");
            return;
        }

        if (number == head.HouseNumber)
        {
            Console.WriteLine($"Removing house {head.HouseNumber}");
            head = head.Next;
            return;
        }

        House current = head;
        House previous = null;

        // Searching here. Check if it's not null and if the number requested appears
        while (current!= null && current.HouseNumber != number)
        {
            previous = current;
            current = current.Next;
        }

        // Check if it's numm/empty
        if (current == null)
        {
            Console.WriteLine("House not found.");
        }
        else
        {
            Console.WriteLine($"Removed house {current.HouseNumber}");
            previous.Next = current.Next;
        }
    }

    public void DisplayAll()
    {
        if (head == null)
        {
            Console.WriteLine("This list is empty.");
            return;
        }
        
        House current = head;
        while (current != null)
        {
            Console.WriteLine($"House Number: {current.HouseNumber}, Address: {current.Address}, Type: {current.TypeOfHouse}");
            current = current.Next;
        }
    }
}