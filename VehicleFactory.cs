/* **Factory Pattern for Object Creation**

Implement a `VehicleFactory` class that returns
different vehicle objects (`Car`, `Bike`) based on an input parameter.*/

using System;

namespace FactoryPatternExample
{
    // Define the Vehicle base class
    public abstract class Vehicle
    {
        public abstract void Drive();
    }

    // Implement the Car class
    public class Car : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Driving a car.");
        }
    }

    // Implement the Bike class
    public class Bike : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Riding a bike.");
        }
    }

    // Implement the VehicleFactory class
    public class VehicleFactory
    {
        public static Vehicle GetVehicle(string vehicleType)
        {
            switch (vehicleType.ToLower())
            {
                case "car":
                    return new Car();
                case "bike":
                    return new Bike();
                default:
                    throw new ArgumentException("Invalid vehicle type");
            }
        }
    }

    /*class Program
    {
        static void Main(string[] args)
        {
            // Create a car using the factory
            Vehicle car = VehicleFactory.GetVehicle("car");
            car.Drive();

            // Create a bike using the factory
            Vehicle bike = VehicleFactory.GetVehicle("bike");
            bike.Drive();
        }
    }*/
}
