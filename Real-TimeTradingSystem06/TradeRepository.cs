using System.Collections.Generic;
public class TradeRepository<T> where T: Trade
{
    private List<T> trades= new List<T>();

    public void AddTrade(T trade)
    {
        trades.Add(trade);
        TradeAnalystics.IncrementTradeCount();
        Console.WriteLine("Trade added successfully");
    }

    public IEnumerable<T> GetTrades() => trades;

}