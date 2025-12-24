using System;

public class Program
{
    public static void ProcessTrade(Trade trade)
    {
        if( trade is EquityTrade equityTrade)
        {
            Console.WriteLine("Processing Equity Trade");
        }
    }

    public static void Main(string[] args)
    {
        PriceSnapshot ps = new PriceSnapshot{ Symbol = "AAPL" , Price = 150.00 };
        Console.WriteLine($"Stock {ps.Symbol} is priced at {ps.Price}");

        var repo = new TradeRepository<EquityTrade>();

        var trade1 = new EquityTrade{ TradeId = 1, Symbol = "AAPL", Quantity = 100, MarketPrice = 150.00 };
        var trade2 = new EquityTrade{ TradeId = 2, Symbol = "TCS", Quantity = 50, MarketPrice = 250.00 };
        

        repo.AddTrade(trade1);
        repo.AddTrade(trade2);

        object boxed = TradeAnalystics.GetTotalTrades();
        Console.WriteLine($"Boxed Trade Count: {boxed}");
        int unboxed = (int)boxed;
        Console.WriteLine($"Unboxed Trade Count: {unboxed}");


        foreach(var trade in repo.GetTrades())
        {
            ProcessTrade(trade);

            double value = trade.CalculateTradeValue();
            Console.WriteLine($"Trade Value: {value}");
            double brokerage = value.CalculateBrokerage();
            Console.WriteLine($"Brokerage: {brokerage}");
            double gst = brokerage.CalculateGST();
            Console.WriteLine($"GST: {gst}");

            Console.WriteLine(trade.ToString());
            Console.WriteLine();
        }

        TradeAnalystics.DisplayAnalytics();
    }
}