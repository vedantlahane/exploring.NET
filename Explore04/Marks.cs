/// <summary>
/// Class demonstrating read-only indexer for marks array.
/// </summary>
class Marks
{
    /// <summary>
    /// Array of marks.
    /// </summary>
    private int[] marks ={80,90,85};

    /// <summary>
    /// Read-only indexer to access marks by index.
    /// </summary>
    /// <param name="index">The index of the mark.</param>
    /// <returns>The mark at the specified index.</returns>
    public int this[int index]
    {
        get
        {
            return marks[index];
        }
    }
}