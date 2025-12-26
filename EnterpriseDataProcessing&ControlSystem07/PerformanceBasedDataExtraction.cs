class PerformanceBasedDataExtraction
{
    public void PerformanceBasedDataExtractionTask03(int[,] sales, double productAverage)
    {
        if (sales == null || sales.Length == 0)
        {
            Console.WriteLine("No sales data provided for performance extraction.");
            return;
        }

        int branches = sales.GetLength(0);
        int months = sales.GetLength(1);

        Console.WriteLine($"\nOverall product average (from Task 1): {productAverage:F2}");
        int[][] qualifying = new int[branches][];
        for (int i = 0; i < branches; i++)
        {
            int count = 0;
            for (int j = 0; j < months; j++) if (sales[i, j] >= productAverage) count++;
            qualifying[i] = new int[count];
            int idx = 0;
            for (int j = 0; j < months; j++)
            {
                if (sales[i, j] >= productAverage)
                {
                    qualifying[i][idx++] = sales[i, j];
                }
            }
        }
        Console.WriteLine("\nQualifying sales (branch-wise):");
        for (int i = 0; i < branches; i++)
        {
            Console.Write($"Branch {i + 1} (count: {qualifying[i].Length}): ");
            if (qualifying[i].Length == 0)
            {
                Console.WriteLine("<no qualifying sales>");
                continue;
            }
            for (int k = 0; k < qualifying[i].Length; k++)
            {
                Console.Write(qualifying[i][k]);
                if (k < qualifying[i].Length - 1) Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}