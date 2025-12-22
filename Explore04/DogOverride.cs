using System;

/// <summary>
/// Derived class that overrides the Sound method.
/// Demonstrates method overriding.
/// </summary>
class DogOverride : AnimalOverride
{
    /// <summary>
    /// Overrides the virtual Sound method from AnimalOverride.
    /// Calls base method and adds dog-specific sound.
    /// </summary>
    public override void Sound()
    {
        base.Sound();
        Console.WriteLine("Dog barks");
    }
}