using Microsoft.EntityFrameworkCore;

namespace BookTracker.Server.PostgreSQL
{
    public class BookTrackerContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("")
    }
}
