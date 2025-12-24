public abstract class Trade
{
    public int TradeId{get;set;}
    public string Symbol{get;set;}
    public int Quantity{get;set;}

    public abstract double CalculateTradeValue();

    public override string ToString()
    {
        return $"TradeId: {TradeId}, Symbol: {Symbol}, Quantity: {Quantity}, TradeValue: {CalculateTradeValue()}";
    }
}