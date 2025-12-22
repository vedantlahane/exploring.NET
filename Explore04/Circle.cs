using System; // Required for Math.PI

/// <summary>
/// Class representing a circle with radius and computed area.
/// Demonstrates constructors and read-only properties.
/// </summary>
class Circle
{
    // Private field for radius: Encapsulates the data, accessed indirectly.
    private double radius;

    // Constructor: Initializes the radius when creating a Circle object.
    // Demonstrates parameterized constructors for setting initial state.
    /// <summary>
    /// Constructor for Circle class.
    /// </summary>
    /// <param name="r">The radius of the circle.</param>
    public Circle(double r)
    {
        radius = r;
    }

    // Read-only property for Area: Only getter, computes area on-the-fly.
    // Shows computed properties; no setter as area is derived from radius.
    /// <summary>
    /// Gets the area of the circle.
    /// Computed as π * r².
    /// </summary>
    public double Area
    {
        get
        {
            return Math.PI * radius * radius;
        }
    }
}