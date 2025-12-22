using System; // Required for Math.PI

class Circle
{
    // Private field for radius: Encapsulates the data, accessed indirectly.
    private double radius;

    // Constructor: Initializes the radius when creating a Circle object.
    // Demonstrates parameterized constructors for setting initial state.
    public Circle(double r)
    {
        radius = r;
    }

    // Read-only property for Area: Only getter, computes area on-the-fly.
    // Shows computed properties; no setter as area is derived from radius.
    public double Area
    {
        get
        {
            return Math.PI * radius * radius;
        }
    }
}