/*
Overloading: Write a simple Maths class ( don’t use the keyword Math, it will be a conflict with standard class from system). 
Write overloaded methods with logic and give choice to user to call different methods :
a. Add(int num1, int num2)
b. Add(decimal num1, decimal num2, decimal num3)
c. Multiply(float num1, float num2)
d. Multiply( float num1, float num2, float num3)
Declare these methods as public and static.

*/

using System;

class MathOperations
{
    // Method for Add
    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    // Overload Add
    public static int Add(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }

    // Method for Multiply
    public static int Multiply(int num1, int num2)  // 🛠 fixed the spacing
    {
        return num1 * num2;
    }

    // Overload Multiply
    public static int Multiply(int num1, int num2, int num3)
    {
        return num1 * num2 * num3;
    }
}

