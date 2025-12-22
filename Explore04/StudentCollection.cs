using System;

/// <summary>
/// Class demonstrating a custom indexer with validation.
/// </summary>
class StudentCollection
{
    /// <summary>
    /// Array to store student names.
    /// </summary>
    private string[] students = new string[3];

    /// <summary>
    /// Indexer for accessing students with bounds checking.
    /// </summary>
    /// <param name="index">The index of the student.</param>
    /// <returns>The student name at the index.</returns>
    public string this[int index]
    {
        get
        {
            if(index < 0 || index >= students.Length)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
            return students[index];
        }
        set
        {
            if(index >= 0 && index < students.Length)
            {
                students[index] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
        }
    }
}