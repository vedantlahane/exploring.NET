public class EquityTrade : Trade
{
    public double? MarketPrice {get; set;}

    public override double CalculateTradeValue()
    {
        return (MarketPrice ?? 0) * Quantity;
    }
}