using System;

/// <summary>
/// Base class for animals with virtual method.
/// Demonstrates method overriding.
/// </summary>
class AnimalOverride
{
    /// <summary>
    /// Virtual method that can be overridden by derived classes.
    /// Makes a generic animal sound.
    /// </summary>
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes sound");
    }
}