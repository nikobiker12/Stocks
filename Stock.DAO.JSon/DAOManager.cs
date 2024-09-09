using Microsoft.EntityFrameworkCore;
using Stocks;

namespace Stock.DAO.Default
{
    public class DAOManager
    {
        private StockDbContext? _dbContext;

        public void Initialize()
        {
            string connectionString = "Data Source=stock.db";
            DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlite(connectionString);

            _dbContext = new StockDbContext(optionsBuilder.Options);
            _dbContext.Database.EnsureCreated();
        }

        public void SaveTrade(Trade trade)
        {
            if (_dbContext is null)
                throw new InvalidOperationException("The DAOManager has not been initialized.");

            _dbContext.Trades.Add(trade);
            _dbContext.SaveChanges();
        }
    }
}
