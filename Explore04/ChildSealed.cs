using System;

/// <summary>
/// Derived class that seals the overridden method.
/// Demonstrates sealed override methods.
/// </summary>
class ChildSealed : ParentSealed
{
    /// <summary>
    /// Sealed override method that cannot be overridden further.
    /// </summary>
    public sealed override void Show()
    {
        Console.WriteLine("Child Show");
    }
}