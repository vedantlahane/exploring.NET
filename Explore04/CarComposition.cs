using System;

/// <summary>
/// Class representing a car using composition.
/// Contains an Engine object instead of inheriting.
/// Demonstrates composition over inheritance.
/// </summary>
class CarComposition
{
    /// <summary>
    /// Engine instance used by the car.
    /// </summary>
    Engine engine = new Engine();

    /// <summary>
    /// Drives the car by starting the engine and driving.
    /// </summary>
    public void Drive()
    {
        engine.Start();
        Console.WriteLine("Car is driving");
    }
}