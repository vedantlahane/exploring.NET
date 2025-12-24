public static class FinancialExtensions
{
    public static double CalculateBrokerage(this double value)
    {
        return value * 0.02;
    }

    public static double CalculateGST(this double value)
    {
        return value * 0.18;
    }
}