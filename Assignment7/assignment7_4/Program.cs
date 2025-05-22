/*
Leet Code 1603
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        //tested on leetcode
    }
}
public class ParkingSystem
{
    // Add properties
    int big;
    int medium;
    int small;

    //Constructor
    public ParkingSystem(int big, int medium, int small)
    {
        this.big = big;
        this.medium = medium;
        this.small = small;
    }

    // if-elseif or switchcase
    public bool AddCar(int carType)
    {
        if (carType == 1 && big > 0)
        {
            big--;
            return true;
        }
        else if (carType == 2 && medium > 0)
        {
            medium--;
            return true;
        }
        else if (carType == 3 && small > 0)
        {
            small--;
            return true;
        }
        else
        {
            return false;
        }
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */