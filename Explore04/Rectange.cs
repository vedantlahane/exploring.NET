/// <summary>
/// Class representing a rectangle.
/// Demonstrates auto-implemented properties and expression-bodied properties.
/// </summary>
class Rectangle
{
    // Standard properties for Length and Width: Fully accessible.
    /// <summary>
    /// Gets or sets the length of the rectangle.
    /// </summary>
    public double Length { get; set; }

    /// <summary>
    /// Gets or sets the width of the rectangle.
    /// </summary>
    public double Width { get; set; }

    // Expression-bodied property for Area: Read-only, computed as Length * Width.
    // Uses => for concise syntax; equivalent to { get { return Length * Width; } }.
    // Demonstrates computed properties without boilerplate.
    /// <summary>
    /// Gets the area of the rectangle.
    /// Computed as Length * Width.
    /// </summary>
    public double Area => Length * Width;
}