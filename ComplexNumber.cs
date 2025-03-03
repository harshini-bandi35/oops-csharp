/***Operator Overloading for Complex Numbers**

Create a `ComplexNumber` class with properties 
`Real` and `Imaginary`. Overload the `+` operator
to add two complex numbers.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp2
{
    class ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        // Overload the + operator to add two complex numbers
        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
    }
}

