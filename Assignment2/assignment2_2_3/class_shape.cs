/*
 Write a abstract base class: ‘Shape’ and add properties like id, name and color and method ‘calculate area’ .
Inherit circle shape from base class and add properties like radius. override calculate area logic for circle.
Inherit square class from shape and change the calculate area logic. Add property like side of square.
Take the input from user to select circle or square and display the calculated area . no hard coded values!
*/
using System;

abstract class Shape {
    public string ID { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public abstract double CalculateArea();// method is abstract cus each shape has its own area implementation

}

class Circle : Shape {
    
    public int Radius { get; set; }

    public override double CalculateArea() {

        return (double)(Math.PI * Radius * Radius);
    }
}

class Square: Shape {
    public double Side { get; set; }
    public override double CalculateArea() {
        
        return Side * Side;
    }
}