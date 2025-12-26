class BranchSalesAnalysis
{
    public int[,] BranchSalesAnalysisTask02()
    {
        Console.Write("Enter number of branches: ");
        if (!int.TryParse(Console.ReadLine(), out int branches) || branches <= 0)
        {
            Console.WriteLine("Invalid number of branches.");
            return new int[0, 0];
        }
        Console.Write("Enter number of months: ");
        if (!int.TryParse(Console.ReadLine(), out int months) || months <= 0)
        {
            Console.WriteLine("Invalid number of months.");
            return new int[0, 0];
        }

        int[,] sales = new int[branches, months];
        for (int i = 0; i < branches; i++)
        {
            for (int j = 0; j < months; j++)
            {
                Console.Write($"Enter sales for branch {i + 1}, month {j + 1}: ");
                if (!int.TryParse(Console.ReadLine(), out sales[i, j]))
                {
                    Console.WriteLine("Invalid sales value.");
                    j--; // retry
                }
            }
        }

        // Calculate total sales per branch and the highest monthly sale across all branches
        int[] branchTotals = new int[branches];
        int highestSale = int.MinValue;

        for (int i = 0; i < branches; i++)
        {
            int sum = 0;
            for (int j = 0; j < months; j++)
            {
                sum += sales[i, j];
                if (sales[i, j] > highestSale) highestSale = sales[i, j];
            }
            branchTotals[i] = sum;
        }

        // Display branch totals and global highest sale
        Console.WriteLine();
        Console.WriteLine("Branch totals:");
        for (int i = 0; i < branches; i++)
        {
            Console.WriteLine($"Branch {i + 1}: {branchTotals[i]}");
        }

        Console.WriteLine($"\nHighest monthly sale across all branches: {highestSale}");
        return sales;
    }
}