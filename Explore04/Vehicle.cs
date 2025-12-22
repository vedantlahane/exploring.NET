using System;

/// <summary>
/// Base class representing a vehicle.
/// Demonstrates basic inheritance where derived classes can inherit methods.
/// </summary>
class Vehicle
{
    /// <summary>
    /// Starts the vehicle.
    /// This method can be inherited by derived classes.
    /// </summary>
    public void Start()
    {
        Console.WriteLine("Vehicle started");
    }
}