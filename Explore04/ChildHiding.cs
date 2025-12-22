using System;

/// <summary>
/// Derived class that hides the parent's Show method.
/// Demonstrates method hiding using 'new' keyword.
/// </summary>
class ChildHiding : ParentHiding
{
    /// <summary>
    /// Hides the parent's Show method.
    /// Uses 'new' to explicitly hide instead of override.
    /// </summary>
    public new void Show()
    {
        Console.WriteLine("Child Show");
    }
}