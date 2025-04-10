/* Create a structure named “Point” and 2 data members: X and Y coordinate. 
Declare 2 points: P1 and P2. 
Determine if P2 is to the right or left of P1 or on same axis, 
by comparing the x xoordinates. ( if p1.x is more than p2.x , it is to the right )

Struct: https://www.tutorialsteacher.com/csharp/csharp-struct

Can change Struct to Class

"A struct is a value type while a class is a reference type. 
Value types contain their data directly on the stack, 
while reference types store a reference to an object containing the data on the heap."

Let's try do-while
*/

using System;

class Program {

    // Define Struct outside of main. If inside main, it is only avaliable within the main domain.
    // Class outside or inside main depending how accessible you want it. but im lazy.
    class Coordinate
    {
        private double x;
        private double y;
        public double X {  
            get { return x; } 
            set { x = value; } 
        }
        public double Y {  
            get { return y; } 
            set { y = value; } 
        }
    }

        static void Main( string[] args ) {
            
            bool programActive = true;
            string input; // Declare for user inport for nestled do-while loop
            
            do 
            {

                Console.WriteLine($"Please enter the first X coordinate: ");
                double x1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Please enter the first Y coordinate: ");
                double y1 = Convert.ToDouble(Console.ReadLine());

                Coordinate P1 = new Coordinate {X = x1, Y = y1};

                Console.WriteLine();
                
                Console.WriteLine($"Please enter the second X coordinate: ");
                double x2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Please enter the second Y coordinate: ");
                double y2 = Convert.ToDouble(Console.ReadLine());

                Coordinate P2 = new Coordinate {X = x2, Y = y2};

                if (P1.X == P2.X) {
                    Console.WriteLine("The X coordinates are on the same axis!");
                }
                else if (P1.X > P2.X) {
                    Console.WriteLine($"Point 2 is on the left side of the axis of Point 1");

                }
                else {
                    Console.WriteLine($"Point 2 is on the right side of the axis Point 1");
                }
                do
                {
                    Console.Write("Would you like to keep going (yes/no): ");
                    input = Console.ReadLine()?.ToLower() ?? "no"; // Warning CS8602 in case of null, execute no.


                } while (input != "yes" && input != "no"); // doing something new !=

                programActive = (input == "yes");
            }

            while (programActive);
        }

}