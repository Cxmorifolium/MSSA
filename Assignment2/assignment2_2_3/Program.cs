/*
 Write a abstract base class: ‘Shape’ and add properties like id, name and color and method ‘calculate area’ .
Inherit circle shape from base class and add properties like radius. override calculate area logic for circle.
Inherit square class from shape and change the calculate area logic. Add property like side of square.
Take the input from user to select circle or square and display the calculated area . no hard coded values!
*/
using System;

class Program {
    static void Main(string[] args) {

            Console.WriteLine("Please select a shape to calculate the area (circle or square): ");
            string selectShape = Console.ReadLine()?.ToLower(); // user input then go continue to lower instructions

            if (selectShape == "circle") {
                Circle circle = new Circle(); //declare shape
                Console.Write("Enter the radius: ");
                circle.Radius = int.Parse(Console.ReadLine());
                Console.WriteLine($"The area of the circle is {circle.CalculateArea()}");
            }

            else if (selectShape == "square") {
                Square square = new Square();
                Console.Write ("Enter the side length: ");
                square.Side = int.Parse(Console.ReadLine());
                Console.WriteLine($"The area of the square is {square.CalculateArea()}");
            }

            else {
                Console.WriteLine("Please type circle or square.");}
        }
}