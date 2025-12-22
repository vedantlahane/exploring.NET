class Rectangle
{
    // Standard properties for Length and Width: Fully accessible.
    public double Length { get; set; }
    public double Width { get; set; }

    // Expression-bodied property for Area: Read-only, computed as Length * Width.
    // Uses => for concise syntax; equivalent to { get { return Length * Width; } }.
    // Demonstrates computed properties without boilerplate.
    public double Area => Length * Width;
}