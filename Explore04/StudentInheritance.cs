using System;

/// <summary>
/// Derived class representing a student.
/// Inherits from Person and adds RollNo.
/// Demonstrates inheritance with constructor chaining using base().
/// </summary>
class StudentInheritance : Person
{
    /// <summary>
    /// The roll number of the student.
    /// </summary>
    public int RollNo;

    /// <summary>
    /// Constructor for StudentInheritance class.
    /// Calls base constructor to initialize Name, then initializes RollNo.
    /// </summary>
    /// <param name="name">The name of the student.</param>
    /// <param name="roll">The roll number of the student.</param>
    public StudentInheritance(string name, int roll) : base(name)
    {
        RollNo = roll;
    }
}