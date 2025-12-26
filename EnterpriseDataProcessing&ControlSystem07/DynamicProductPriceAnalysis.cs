class DynamicProductPriceAnalysis
{
    public double DynamicProductPriceAnalysisTask01()
    {
        Console.Write("Enter number of products: ");
        int num;
        while (!int.TryParse(Console.ReadLine(), out num) || num <= 0)
        {
            Console.Write("Invalid input. Please enter a positive integer for number of products: ");
        }

        int[] arr = new int[num];

        Console.WriteLine($"Enter {num} positive product prices (one per line):");
        int i = 0;
        while (i < num)
        {
            Console.Write($"Price for product #{i + 1}: ");
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) || !int.TryParse(input, out int temp) || temp <= 0)
            {
                Console.WriteLine("Invalid price. Please enter a positive integer.");
                continue;
            }
            arr[i] = temp;
            i++;
        }

        long sum = 0;
        for (int idx = 0; idx < num; idx++)
        {
            sum += arr[idx];
        }
        double avg = sum / (double)num;
        Console.WriteLine($"\nCalculated average price: {avg}");

        Array.Sort(arr);

        for (int j = 0; j < num; j++)
        {
            if (arr[j] < avg)
            {
                arr[j] = 0;
            }
        }

        Array.Resize(ref arr, num + 5);
        for (int k = num; k < arr.Length; k++)
        {
            arr[k] = (int)avg;
        }
        Console.WriteLine("\nFinal array (index: value):");
        for (int m = 0; m < arr.Length; m++)
        {
            Console.WriteLine($"{m}: {arr[m]}");
        }
        return avg;
    }
}