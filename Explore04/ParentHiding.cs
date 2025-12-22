using System;

/// <summary>
/// Base class for method hiding example.
/// </summary>
class ParentHiding
{
    /// <summary>
    /// Method that will be hidden in derived class.
    /// </summary>
    public void Show()
    {
        Console.WriteLine("Parent Show");
    }
}