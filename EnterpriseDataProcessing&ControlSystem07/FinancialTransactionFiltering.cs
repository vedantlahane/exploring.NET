using System;
using System.Collections.Generic;

class FinancialTransactionFiltering
{
    public void FinancialTransactionFilteringTask05(double productAverage)
    {
        Console.WriteLine("Enter the number of transactions:");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
        {
            Console.WriteLine("Invalid number of transactions.");
            return;
        }

        var transactions = new Dictionary<int, double>();
        for (int i = 0; i < n; i++)
        {
            int id;
            while (true)
            {
                Console.Write($"Transaction {i + 1} ID: ");
                if (!int.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("Invalid input — enter an integer ID.");
                    continue;
                }
                if (transactions.ContainsKey(id))
                {
                    Console.WriteLine("Duplicate transaction ID — please enter a unique ID.");
                    continue;
                }
                break;
            }

            double amount;
            while (true)
            {
                Console.Write($"Transaction {i + 1} Amount: ");
                if (double.TryParse(Console.ReadLine(), out amount))
                {
                    break;
                }
                Console.WriteLine("Invalid input — enter a numeric amount.");
            }

            transactions[id] = amount;
        }

        Console.WriteLine($"\nTotal transactions recorded: {transactions.Count}");
        Console.WriteLine($"Filtering transactions with amount >= product average ({productAverage:F2})\n");

        var highValue = new SortedList<int, double>();
        foreach (var kvp in transactions)
        {
            if (kvp.Value >= productAverage)
            {
                highValue.Add(kvp.Key, kvp.Value);
            }
        }

        if (highValue.Count == 0)
        {
            Console.WriteLine("No high-value transactions found.");
            return;
        }

        Console.WriteLine("High-value transactions (sorted by ID):");
        foreach (var kvp in highValue)
        {
            Console.WriteLine($"ID: {kvp.Key}, Amount: {kvp.Value:F2}");
        }
    }
}