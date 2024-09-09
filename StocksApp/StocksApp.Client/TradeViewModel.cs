using Stocks;

namespace StocksApp.Client
{
    public class TradeBookingViewModel
    {
        public int Id { get; set; }
        public int InstrumentId { get; set; }
        public double Quantity { get; set; }
        public Side Side { get; set; }
        public double Price { get; set; }
        public double Fees { get; set; }
        public DateTime TradeDate { get; set; } = DateTime.UtcNow.Date;
        public DateTime SettlementDate { get; set; } = DateTime.UtcNow.AddDays(2).Date;


    }
}
