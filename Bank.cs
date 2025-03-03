/***Static Members in a Banking System**

Implement a `Bank` class with a static field `InterestRate`
and a static method `SetInterestRate()`. Show how static 
members work across multiple objects.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp2
{
    class Bank
    {
        
        public static double InterestRate { get; private set; }

        public static void SetInterestRate(double rate)
        {
            InterestRate = rate;
        }

        public string Name { get; set; }

        public Bank(string name)
        {
            Name = name;
        }

        public void DisplayInterestRate()
        {
            Console.WriteLine($"Bank: {Name}, Interest Rate: {InterestRate}%");
        }
    }
}

