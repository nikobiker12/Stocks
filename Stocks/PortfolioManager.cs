using Stocks.DAO;

namespace Stocks;

public class PortfolioManager
{
    private readonly ITradeDAO _tradeDAO;

    public PortfolioManager(ITradeDAO tradeDAO)
    {
        this._tradeDAO = tradeDAO ?? throw new ArgumentNullException(nameof(tradeDAO));
    }

    public Trade BookTrade(int instrumentId, double quantity, Side side, double price, double fees, DateTime tradeDate, DateTime settlementDate)
    {
        Trade trade = new Trade(0, instrumentId, quantity, side, price, fees, tradeDate, settlementDate);

        return trade;
    }
}