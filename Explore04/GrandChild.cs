using System;

/// <summary>
/// Attempted derived class from ChildSealed.
/// Demonstrates that sealed methods cannot be overridden.
/// The commented code would cause a compile-time error.
/// </summary>
class GrandChild : ChildSealed
{
    // public override void Show()   // Compile-time error: cannot override sealed method
    // {
    // }
}