namespace Stocks;

public class Trade
{
    public Trade()
    { 
    }

    public Trade(int id, int instrumentId, double quantity, Side side, double price, double fees, DateTime tradeDate, DateTime settlementDate)
    {
        Id = id;
        InstrumentId = instrumentId;
        Quantity = quantity;
        Side = side;
        Price = price;
        Fees = fees;
        TradeDate = tradeDate;
        SettlementDate = settlementDate;
    }

    public int Id { get; set; }
    public int InstrumentId { get; set; }
    public double Quantity { get; set; }
    public Side Side { get; set; }
    public double Price { get; set; }
    public double Fees { get; set; }
    public DateTime TradeDate { get; set; }
    public DateTime SettlementDate { get; set; }
}
