/* 
Write a program in C# to calculate area of triangle, square and rectangle. 
Write 3 different functions for each shape to take dimensions of figure and display the area. 
        There are two methods: text simulated (😖) and using WindowsForm(💀).
You may create menus. 

Helper methods/switch case/for/while loops

triangle: 1/2bh
square and rectangle: bh
*/

using System;

class Program {
    static void Main(string[] args) {

        // Add While Loop Until Program Exit
        bool programActive = true;
        while (programActive) {

            // Create Menu
            Console.WriteLine("Please select a shape:\n" +
                "1. Triangle\n" +
                "2. Square\n" +
                "3. Rectangle\n" +
                "4. Exit");


            // Read User Input
            int area = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height: ");
            double height = Convert.ToDouble(Console.ReadLine());


            // Write switch cases for each option
            switch (area)
            {
                case 1: // Triangle
                    Console.WriteLine($"The area of the triangle is {AreaFormula(width, height, area)}");
                    DrawRightTriangle((int)height); // Cast if needed
                    break;

                case 2: // Square
                    Console.WriteLine($"The area of the square is {AreaFormula(width, height, area)}");
                    DrawRectangleOrSquare((int)width, (int)height);
                    break;

                case 3: // Rectangle
                    Console.WriteLine($"The area of the rectangle is {AreaFormula(width, height, area)}");
                    DrawRectangleOrSquare((int)width, (int)height);
                    break;

                case 4: // Exit case
                    programActive = false;
                    Console.WriteLine("So long. Farewell. Adieu.");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            // handle user input
            if (area != 4) // If the user didn't choose option '4', ask to continue
            {
                while (true)
                {
                    Console.Write("\nWould you like to calculate another shape? (yes/no): ");
                    string response = Console.ReadLine()?.ToLower() ?? ""; //handle null

                    if (response == "yes")
                    {
                        break; // continue with program
                    }
                    else if (response == "no")
                    {
                        programActive = false;
                        Console.WriteLine("So long. Farewell. Adieu.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please respond with 'yes' or 'no'.");
                    }
                }
            }

        }
    }
    // Helper Methods: Formula
    static double AreaFormula(double width, double height, int area) {
        switch(area){
            case 1: // Triangle formula 
                return 0.5*width*height;
            case 2: // Square
            case 3: //Rectangle
                return width*height;
            default:
                return 0;
        }
    }


    // Helper Methods: Drawing Shapes
    /* iterate to draw dots per line for (i=0; i+1; i++){}
    ex: L = 3 H = 3
    ***
    ***
    ***
    close enough squares can be rectangles.

    *
    **
    ***
    **** it's all going to be right triangles and user imagination for simplicity

    */

// I hate for loops and triangles. i "height" j " stars per row"
    static void DrawRightTriangle(int height)
    {
        Console.WriteLine("If you label the height and width in your brain it's totally accurate");
        for (int i = 1; i <= height; i++) // for height. this triangle is based on height only for simplicity.
        {
            for (int j = 0; j < i; j++) // loops starts 
            {
                Console.Write("*"); // * per line based on input so row 1:1 2:2 3:3
            }
            Console.WriteLine();
        }
    }

    // Because all squares are rectangle:
    static void DrawRectangleOrSquare(int width, int height)
    {
        for (int i = 0; i < height; i++) // loop through height
        {
            for (int j = 0; j < width; j++) // loops through width
            {
                Console.Write("*"); // for every column there's a star in the row
            }
            Console.WriteLine();
        }
    }

}