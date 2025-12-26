using System;
using System.Collections.Generic;
using System.Collections;

class ProcessFlowManagement
{
    public void ProcessFlowManagementTask06()
    {
        Console.WriteLine("Enter the number of operations:");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
        {
            Console.WriteLine("Invalid number of operations.");
            return;
        }

        Queue<string> processingQueue = new Queue<string>();
        Stack<string> undoStack = new Stack<string>();

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Operation {i + 1} description: ");
            string op = Console.ReadLine() ?? string.Empty;
            processingQueue.Enqueue(op);
            undoStack.Push(op);
        }

        Console.WriteLine("\nProcessing operations (FIFO):");
        var processed = new List<string>();
        while (processingQueue.Count > 0)
        {
            var op = processingQueue.Dequeue();
            processed.Add(op);
            Console.WriteLine($"Processed: {op}");
        }

        // Undo last two operations using stack (LIFO)
        Console.WriteLine("\nUndoing last two operations (if available):");
        var undone = new List<string>();
        for (int k = 0; k < 2 && undoStack.Count > 0; k++)
        {
            var op = undoStack.Pop();
            undone.Add(op);
            Console.WriteLine($"Undone: {op}");
        }

        Console.WriteLine("\nSummary:");
        Console.WriteLine("Processed operations:");
        for (int i = 0; i < processed.Count; i++) Console.WriteLine($"[{i}]: {processed[i]}");

        Console.WriteLine("\nUndone operations:");
        if (undone.Count == 0) Console.WriteLine("<none>");
        else for (int i = 0; i < undone.Count; i++) Console.WriteLine($"[{i}]: {undone[i]}");
    }
}