class MathOperations
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static int Sum(params int[] num)
    {
        int total = 0;
        foreach (int a in num)
        {
            total += a;
        }
        return total;
    }

    public static void Main(string[] args)
    {
        string name = "Vedant";
        Console.WriteLine($"Hello, {name}!");
        Console.WriteLine($"Add ints: {Add(1, 2)}");
        Console.WriteLine($"Add doubles: {Add(1.5, 2.5)}");
        Console.WriteLine($"Sum: {Sum(1, 2, 3, 4, 5)}");
    }
}
