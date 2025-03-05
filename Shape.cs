/***Abstraction with Abstract Classes**

Design an abstract class `Shape` with an abstract method 
`CalculateArea()`. Create derived classes `Circle` and `Rectangle`
that implement this method. Demonstrate abstraction by instantiating these classes.
*/
/***Abstraction with Abstract Classes**/
using System;

abstract class Shape
{
    // Abstract method
    public abstract double CalculateArea();
}

class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Implementing the abstract method
    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
}

class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    // Implementing the abstract method
    public override double CalculateArea()
    {
        return length * width;
    }
}
