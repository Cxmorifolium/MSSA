using System.Collections.Generic;
using System;

public class House
{
    public int HouseNumber { get; set; }
    public string Address { get; set; }
    public string TypeOfHouse { get; set; }
    public House Next { get; set; }

    // Create constructor 
    public House(int number, string address, string type)
    {
        HouseNumber = number;
        Address = address;
        TypeOfHouse = type;
        Next = null;
    }
}