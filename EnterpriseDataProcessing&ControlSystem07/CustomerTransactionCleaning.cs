using System;
using System.Collections.Generic;

class CustomerTransactionCleaning
{
    public void CustomerTransactionCleaningTask04()
    {
        Console.WriteLine("Enter the number of customer transactions:");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
        {
            Console.WriteLine("Invalid number of transactions.");
            return;
        }

        List<int> transactions = new List<int>();
        for (int i = 0; i < n; i++)
        {
            int id;
            while (true)
            {
                Console.Write($"Transaction {i + 1} ID: ");
                if (int.TryParse(Console.ReadLine(), out id))
                {
                    transactions.Add(id);
                    break;
                }
                Console.WriteLine("Invalid input — enter an integer ID.");
            }
        }

        Console.WriteLine($"\nOriginal transaction count: {transactions.Count}");

        // Remove duplicates using HashSet and convert back to List (round-trip)
        HashSet<int> unique = new HashSet<int>(transactions);
        List<int> cleaned = new List<int>(unique);

        Console.WriteLine("\nCleaned customer list (duplicates removed):");
        for (int i = 0; i < cleaned.Count; i++)
        {
            Console.WriteLine($"[{i}]: {cleaned[i]}");
        }

        int duplicatesRemoved = transactions.Count - cleaned.Count;
        Console.WriteLine($"\nNumber of duplicate entries removed: {duplicatesRemoved}");
    }
}