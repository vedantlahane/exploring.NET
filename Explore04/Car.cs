using System;

/// <summary>
/// Derived class representing a car.
/// Inherits from Vehicle and adds its own method.
/// Demonstrates basic inheritance.
/// </summary>
class Car : Vehicle
{
    /// <summary>
    /// Drives the car.
    /// This is a method specific to the Car class.
    /// </summary>
    public void Drive()
    {
        Console.WriteLine("Car is driving");
    }
}