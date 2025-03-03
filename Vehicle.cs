using System;

namespace csharp2
{
    abstract class Vehicle
    {
        public abstract void Start();
    }

    class Bike : Vehicle
    {
        public override void Start()
        {
            int wheels = 2;
            Console.WriteLine("The number of wheels a bike has is: " + wheels);
        }
    }

    class Car : Vehicle
    {
        public override void Start()
        {
            int wheels = 4;
            int windows = 4;
            int sum = wheels + windows;
            Console.WriteLine("The sum of wheels and windows in a car is: " + sum);
        }
    }

}
