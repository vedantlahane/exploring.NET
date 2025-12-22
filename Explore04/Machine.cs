using System;

/// <summary>
/// Class representing a machine that can print and scan.
/// Implements multiple interfaces.
/// Demonstrates interface implementation.
/// </summary>
class Machine : IPrintable, IScannable
{
    /// <summary>
    /// Implements the Print method from IPrintable.
    /// </summary>
    public void Print()
    {
        Console.WriteLine("Printing");
    }

    /// <summary>
    /// Implements the Scan method from IScannable.
    /// </summary>
    public void Scan()
    {
        Console.WriteLine("Scanning");
    }
}