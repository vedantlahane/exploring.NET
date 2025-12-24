public static class TradeAnalystics
{
    private static int totalTrades = 0;
    public static void IncrementTradeCount() => totalTrades++;

    public static int GetTotalTrades() => totalTrades;

    public static void DisplayAnalytics()
    {
        Console.WriteLine($"Total Trades Executed: {totalTrades}");
    }

}