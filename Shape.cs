/***Abstraction with Abstract Classes**

Design an abstract class `Shape` with an abstract method 
`CalculateArea()`. Create derived classes `Circle` and `Rectangle`
that implement this method. Demonstrate abstraction by instantiating these classes.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp2
{
    abstract class Shape
    {
        double Length, Breadth;
        double Radius;
        public void CalculateArea(double length,double breadth,double radius)
        {
            Length = length;
            Breadth = breadth;
            Radius = radius;

        }
    }
    class Rectangle : Shape
    {
        public void CalculateArea(double length, double breadth)
        {
            double areaRectangle = length * breadth;
            Console.WriteLine("The area of rectangle is: " + areaRectangle);

        }
        

    }
    class Circle : Shape
    {
        public void CalculateArea(double radius)
        {
            double areacircle = 3.14 * radius * radius;
            Console.WriteLine("The area of circle is:" + areacircle);


        }
    }
    

}
