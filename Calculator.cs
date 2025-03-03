/***Method Overloading in a Calculator Class**

Implement a `Calculator` class with overloaded methods `Add()`. 
It should accept two integers, three integers, and two double 
values separately. Demonstrate how method overloading works.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp2
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;   
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public double Add(double a,double b)
        {
            return a + b;
        }
    }
}
