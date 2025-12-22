using System;

/// <summary>
/// Base class representing a person.
/// Demonstrates inheritance with constructors.
/// </summary>
class Person
{
    /// <summary>
    /// The name of the person.
    /// </summary>
    public string Name;

    /// <summary>
    /// Constructor for Person class.
    /// Initializes the Name property.
    /// </summary>
    /// <param name="name">The name of the person.</param>
    public Person(string name)
    {
        Name = name;
    }
}