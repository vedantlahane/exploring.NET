using System;

/// <summary>
/// Derived class representing a human.
/// Inherits from LivingBeing and adds Think method.
/// Part of multilevel inheritance.
/// </summary>
class Human : LivingBeing
{
    /// <summary>
    /// Method for thinking.
    /// </summary>
    public void Think()
    {
        Console.WriteLine("Thinking");
    }
}