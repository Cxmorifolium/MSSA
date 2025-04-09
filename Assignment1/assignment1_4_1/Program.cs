/* Create a structure named “Point” and 2 data members: X and Y coordinate. 
Declare 2 points: P1 and P2. 
Determine if P2 is to the right or left of P1 or on same axis, 
by comparing the x xoordinates. ( if p1.x is more than p2.x , it is to the right )

Struct: https://www.tutorialsteacher.com/csharp/csharp-struct

Let's try do-while
*/

using System;

class Program {

    // Define Struct outside of main. If inside main, it is only avaliable within the main domain.
    struct Coordinate
    {
        public double x;
        public double y;
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

                Coordinate P1 = new Coordinate {x = x1, y = y1};

                Console.WriteLine();

                
                Console.WriteLine($"Please enter the second X coordinate: ");
                double x2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Please enter the second Y coordinate: ");
                double y2 = Convert.ToDouble(Console.ReadLine());

                Coordinate P2 = new Coordinate {x = x2, y = y2};

                if (P1.x == P2.x) {
                    Console.WriteLine("The X coordinates are on the same axis!");
                }
                else if (P1.x > P2.x) {
                    Console.WriteLine($"Point 2 is on the left side of the axis of Point 1");

                }
                else {
                    Console.WriteLine($"Point 2 is on the right side of the axis Point 1");
                }
                do
                {
                    Console.Write("Would you like to keep going (yes/no): ");
                    input = Console.ReadLine()?.ToLower() ?? "no"; // Warning CS8602 in case of null, execute no.


                } while (input != "yes" && input != "no");

                programActive = (input == "yes");
            }

            while (programActive);
        }

}