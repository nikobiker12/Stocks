
using Microsoft.EntityFrameworkCore;
using Stocks;

namespace Stock.DAO.Default
{
    internal class StockDbContext : DbContext
    {
        public StockDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Trade> Trades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure Trade entity
            modelBuilder.Entity<Trade>()
                .HasKey(t => t.Id);
        }
    }
}