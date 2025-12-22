using System;

/// <summary>
/// Base class with virtual method.
/// Demonstrates sealed methods.
/// </summary>
class ParentSealed
{
    /// <summary>
    /// Virtual method that can be overridden.
    /// </summary>
    public virtual void Show()
    {
        Console.WriteLine("Parent Show");
    }
}