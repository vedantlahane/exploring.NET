using System;
using System.Collections;

class LegacyDataRiskDemonstration
{
    public void LegacyDataRiskDemonstrationTask07()
    {
        Console.WriteLine("Enter the number of users:");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
        {
            Console.WriteLine("Invalid number of users.");
            return;
        }

        Hashtable userRoles = new Hashtable();
        ArrayList mixedData = new ArrayList();

        for (int i = 0; i < n; i++)
        {
            Console.Write($"User {i + 1} name: ");
            string name = Console.ReadLine() ?? string.Empty;
            Console.Write($"User {i + 1} role: ");
            string role = Console.ReadLine() ?? string.Empty;

            userRoles[name] = role;
            mixedData.Add(name);
            mixedData.Add(role);
        }

        Console.WriteLine("\nHashtable (key-value pairs):");
        foreach (DictionaryEntry entry in userRoles)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }

        Console.WriteLine("\nArrayList (mixed data):");
        for (int i = 0; i < mixedData.Count; i++)
        {
            Console.WriteLine($"[{i}]: {mixedData[i]}");
        }

        Console.WriteLine("\nRisk demonstration:");
        Console.WriteLine("- Hashtable provides type safety and clear key-value relationships.");
        Console.WriteLine("- ArrayList allows mixing types, leading to potential runtime errors and maintenance issues.");
    }
}