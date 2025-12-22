using System.Linq; // Required for FirstOrDefault

/// <summary>
/// Class demonstrating indexers.
/// Allows accessing employees by ID or name.
/// </summary>
class EmployeeDirectory
{
    /// <summary>
    /// Dictionary to store employees: ID -> Name
    /// </summary>
    private Dictionary<int, string> employees = new Dictionary<int, string>();

    /// <summary>
    /// Indexer for accessing employee name by ID.
    /// </summary>
    /// <param name="id">Employee ID.</param>
    /// <returns>Employee name.</returns>
    public string this[int id]
    {
        get{return employees[id];}
        set{employees[id] = value;}
    }

    /// <summary>
    /// Indexer for accessing employee ID by name.
    /// </summary>
    /// <param name="name">Employee name.</param>
    /// <returns>Employee ID as string.</returns>
    public string this[string name]
    {
        get
        {
            return employees.FirstOrDefault(e => e.Value == name).Key.ToString();
        }
    }
}