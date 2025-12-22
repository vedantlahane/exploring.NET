using System;

/// <summary>
/// Derived class representing a dog.
/// Inherits from Animal and adds Bark method.
/// Demonstrates single inheritance.
/// </summary>
class Dog : Animal
{
    /// <summary>
    /// Method for the dog to bark.
    /// </summary>
    public void Bark()
    {
        Console.WriteLine("Dog barks");
    }
}