using System;

/// <summary>
/// Derived class representing an employee.
/// Inherits from Human and adds Work method.
/// Demonstrates multilevel inheritance.
/// </summary>
class EmployeeInheritance : Human
{
    /// <summary>
    /// Method for working.
    /// </summary>
    public void Work()
    {
        Console.WriteLine("Working");
    }
}