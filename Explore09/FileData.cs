using System;
using System.IO;

class FileData
{
    public FileData()
    {
        FileStream file = null;
        try
        {
            file = new FileStream("data.txt", FileMode.Open);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            file?.Dispose();
        }
    }
}