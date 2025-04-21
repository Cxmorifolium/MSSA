// Create a console application to overload “+” and “-“ operator 
// for adding the areas of 2 circles and getting their area difference respectively.

using System;

class Circle
{
    public double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double Area => Math.PI * Radius * Radius;

    public static double operator +(Circle c1, Circle c2) => c1.Area + c2.Area;


    public static double operator -(Circle c1, Circle c2) => c1.Area - c2.Area;
}

class Program {
    static void Main(string[] args) 
    {

        Console.WriteLine("Please enter a radius to calculate the area of Circle 1: ");
        double radius1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Please enter a radius to calculate the area of Circle 2: ");
        double radius2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Please enter 'addition' or 'subtraction' to evaluate the sum or difference of the two circles: ");
        string operation = Console.ReadLine();

        Circle circle1 = new Circle(radius1);
        Circle circle2 = new Circle(radius2);

        double result = 0;
        string symbol = "";

        switch (operation.ToLower())
        {
            case "addition":
                result = circle1 + circle2;  // uses overloaded +
                symbol = "+";
                break;
            case "subtraction":
                result = circle1 - circle2;  // uses overloaded -
                symbol = "-";
                break;
            default:
                Console.WriteLine("Invalid operation. Please use 'add' or 'subtract'.");
                return;
        }

        Console.WriteLine($@"
        The area of Circle 1 is: {circle1.Area}
        The area of Circle 2 is: {circle2.Area}
        The result of Circle 1 {symbol} Circle 2 is: {result}");
    
    }

}
