/*
Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
Test Data :
Input the value for X coordinate :7
Input the value for Y coordinate :9
Expected Output :
The coordinate point (7,9) lies in the First quadrant.
*/

/*Maybe useful:
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

//         static void FirstQuadrant (decimal X, decimal Y) {
                if ( X > 0 && Y > 0) {
                Console.WriteLine "The coordinate points {} lies in the First Quadrant!}
                }
            
            static void SecondQuadrant (decimal X, decimal Y) {
                if ( X < 0 && Y > 0) {
                Console.WriteLine "The coordinate points {} lies in the Second Quadrant!}
                }
            
            static void ThirdQuadrant (decimal X, decimal Y) {
                if ( X < 0 && Y < 0) {
                Console.WriteLine "The coordinate points {} lies in the Third Quadrant!}
                }
            
            static void FourtgQuadrant (decimal X, decimal Y) {
                if ( X > 0 && Y < 0) {
                Console.WriteLine "The coordinate points {} lies in the Fourth Quadrant!}
                }
    
    Conclusion: Switch Case prob better maybe? 

    Coordinates[] points = {X, Y}; <- look up if this is valid -> found Pattern Matching Switch Cases
    EX:
    string WaterState(int tempInFahrenheit) =>
    tempInFahrenheit switch
    {
        (> 32) and (< 212) => "liquid",
        < 32 => "solid",
        > 212 => "gas",
        32 => "solid/liquid transition",
        212 => "liquid / gas transition",
    };
    
    so transform it for this case:
    ranges for coordinate planes (x, y):
    {
     (x>0) && (y>0) => "First Quadrant",
     (x<0) && (y>0) => "Second Quadrant",
     (x<0) && (y<0) => "Third Quadrant",
     (x>0) && (y<0) => "Fourth Quadrant"
    }; 
    
    Something like that. could put this under class coordinate as well or in main body

    if too complicated use the dreaded elseif lmao

    }
*/

using System;
class Program {
    static void Main(string[] args) {

        Console.Write("Input the value for X coordinate: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Input the value for Y coordinate: ");
        double y = Convert.ToDouble(Console.ReadLine());

        string result = (x, y) switch
        {
            (> 0, > 0) => $"The coordinate point ({x}, {y}) lies in the First quadrant.",
            (< 0, > 0) => $"The coordinate point ({x}, {y}) lies in the Second quadrant.",
            (< 0, < 0) => $"The coordinate point ({x}, {y}) lies in the Third quadrant.",
            (> 0, < 0) => $"The coordinate point ({x}, {y}) lies in the Fourth quadrant.",
            (0, 0) => "The coordinate point lies at the Origin.",
            _ => "The coordinate point has an unrecognized or special value."
        };
        
        Console.WriteLine(result);

    }

}